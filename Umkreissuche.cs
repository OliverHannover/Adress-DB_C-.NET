using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Adress_DB
{
    public partial class Umkreissuche
    {
        public Umkreissuche()
        {
            pd_PrintDoc = new System.Drawing.Printing.PrintDocument();
            InitializeComponent();
            _CB_Staat.Name = "CB_Staat";
            _TB_PLZ.Name = "TB_PLZ";
            _TB_Entfernung.Name = "TB_Entfernung";
            _Button1.Name = "Button1";
            _Button2.Name = "Button2";
            _PrintPreviewDialog1.Name = "PrintPreviewDialog1";
            _Button3.Name = "Button3";
            _BTN_Schliessen.Name = "BTN_Schliessen";
        }

        private DataTable dt;

        private void Form8_Load(object sender, EventArgs e)
        {
            StaatenTableAdapter.Fill(_WSL_AdressenDataSet.Staaten);
            // Me.AdresseMitGeodatenTableAdapter.Fill(Me._WSL_AdressenDataSet.AdresseMitGeodaten)

            // zuerst (wichtig) Combobox Anrede füllen
            {
                var withBlock = CB_Staat;
                withBlock.Items.Add("Deutschland");
                withBlock.Items.Add("Österreich");
                withBlock.Items.Add("Schweiz");
                withBlock.SelectedIndex = 0;
            }

            BundeslandLabel1.Text = string.Empty;
            LandkreisLabel1.Text = string.Empty;
            LatitudeLabel1.Text = string.Empty;
            LongitudeLabel1.Text = string.Empty;
            LBL_Treffer.Text = string.Empty;
            lbl_IDFirmenName.Text = string.Empty;
        }

        private void Umkreissuche_Shown(object sender, EventArgs e)
        {
            if (My.MyProject.Forms.Hauptform.PNL_Geodaten.Visible == true)
            {
                CB_Staat.Text = My.MyProject.Forms.Hauptform.LBL_Land.Text;
                TB_PLZ.Text = My.MyProject.Forms.Hauptform.LBL_PLZ.Text;
                CB_Ort.Text = My.MyProject.Forms.Hauptform.LBL_Ort.Text;
            }
        }

        private void TB_PLZ_TextChanged(object sender, EventArgs e)
        {
            PLZ_GeodatenTableAdapter.SuchePLZInGeodaten(_WSL_AdressenDataSet.PLZ_Geodaten, LBL_Countrycode.Text, TB_PLZ.Text);

            // MsgBox(CB_Ort.Items.Count)
            if (CB_Ort.Items.Count == 0)
            {
                LBL_PLZungueltig.Visible = true;
            }
            else
            {
                LBL_PLZungueltig.Visible = false;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if ((TB_PLZ.Text ?? "") == (string.Empty ?? "") | (CB_Ort.Text ?? "") == (string.Empty ?? "") | (TB_Entfernung.Text ?? "") == (string.Empty ?? ""))
            {
                MessageBox.Show("Bitte alle Felder ausfüllen", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                // Me.AdresseMitGeodatenTableAdapter.SucheUmkreis(_WSL_AdressenDataSet.AdresseMitGeodaten, CDec(LatitudeLabel1.Text), CDec(LongitudeLabel1.Text), CDec(TB_Entfernung.Text))
                dt = AdresseMitGeodatenTableAdapter.GetDataUmkreis(Conversions.ToDecimal(LatitudeLabel1.Text), Conversions.ToDecimal(LongitudeLabel1.Text), Conversions.ToDecimal(TB_Entfernung.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Abrufen der Entfernungen!");
                MessageBox.Show(ex.Message);
            }


            // Wenn die Datentable exisitiert, bzw mit Daten ngefüllt ist.. 
            if (dt is object)
            {
                LBL_Treffer.Text = dt.Rows.Count.ToString();
                dgv.DataSource = dt;

                // dgv.Columns.RemoveAt(0)
                dgv.Columns.RemoveAt(6);
                dgv.Columns.RemoveAt(6);
                dgv.Columns[6].DefaultCellStyle.Format = "N0";
                dgv.Sort(dgv.Columns[6], System.ComponentModel.ListSortDirection.Ascending);
                dgv.Columns[6].HeaderCell.SortGlyphDirection = SortOrder.Ascending;
                // dgv.AutoResizeColumns()

                {
                    var withBlock = dgv;
                    withBlock.Columns[0].Width = 200;
                    withBlock.Columns[0].HeaderText = "Firma";
                    withBlock.Columns[1].HeaderText = "Art";
                    withBlock.Columns[2].Width = 70;
                    withBlock.Columns[2].HeaderText = "Land";
                    withBlock.Columns[2].Width = 50;
                    withBlock.Columns[6].HeaderText = "ca. km";
                    withBlock.Columns[6].Width = 50;
                }

                {
                    var withBlock1 = lbl_IDFirmenName;
                    withBlock1.DataBindings.Clear();
                    withBlock1.DataBindings.Add(new Binding("Text", dt, "FirmenName", true));
                }
            }
        }

        private void TB_Entfernung_TextChanged(object sender, EventArgs e)
        {
            // muss static sein, da Auswertung erst bei nachfolgenden Aufrufen erfolgt
            int value;
            ;
            // vollständigen inhalt der Textbox holen
            string s = ((Control)sender).Text;
            // beim nächsten Tastendruck zunächst ev. anstehenden Fehler löschen
 
            // überprüfen, ob Inhalt rein numerisch
            if (int.TryParse(s, out value))
            {
                // auf Werte von 1 bis 100 begrenzen
                if (value > 200)
                    value = 200;
                // If value < 10 Then value = 10
                // wieder zurückschreiben
                TB_Entfernung.Text = value.ToString();
            }
            else
            {
                // nicht numerische Zeichen im String
                TB_Entfernung.Text = "10";
                  }
        }

        private void CB_Staat_SelectedIndexChanged(object sender, EventArgs e)
        {
            int foundIndex = StaatenBindingSource.Find("Staat", CB_Staat.Text);
            StaatenBindingSource.Position = foundIndex;
        }

        private void BTN_Schliessen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Hauptform.TB_FirmenName.Text = lbl_IDFirmenName.Text;
            My.MyProject.Forms.Hauptform.BTN_Suche.PerformClick();
        }

        private int mRow = 0;
        private bool newpage = true;

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // sets it to show '...' for long text
            var fmt = new StringFormat(StringFormatFlags.LineLimit);
            fmt.LineAlignment = StringAlignment.Center;
            fmt.Trimming = StringTrimming.EllipsisCharacter;
            int y = e.MarginBounds.Top;
            Rectangle rc;
            int x;
            int h = 0;
            DataGridViewRow row;

            // print the header text for a new page
            // use a grey bg just like the control
            if (newpage)
            {
                row = dgv.Rows[mRow];
                x = e.MarginBounds.Left;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    // since we are printing the control's view,
                    // skip invidible columns
                    if (cell.Visible)
                    {
                        rc = new Rectangle(x, y, cell.Size.Width, cell.Size.Height);
                        e.Graphics.FillRectangle(Brushes.LightGray, rc);
                        e.Graphics.DrawRectangle(Pens.Black, rc);

                        // reused in the data pront - should be a function
                        switch (dgv.Columns[cell.ColumnIndex].DefaultCellStyle.Alignment)
                        {
                            case DataGridViewContentAlignment.BottomRight:
                            case DataGridViewContentAlignment.MiddleRight:
                                {
                                    fmt.Alignment = StringAlignment.Far;
                                    rc.Offset(-1, 0);
                                    break;
                                }

                            case DataGridViewContentAlignment.BottomCenter:
                            case DataGridViewContentAlignment.MiddleCenter:
                                {
                                    fmt.Alignment = StringAlignment.Center;
                                    break;
                                }

                            default:
                                {
                                    fmt.Alignment = StringAlignment.Near;
                                    rc.Offset(2, 0);
                                    break;
                                }
                        }

                        e.Graphics.DrawString(dgv.Columns[cell.ColumnIndex].HeaderText, dgv.Font, Brushes.Black, rc, fmt);
                        x += rc.Width;
                        h = Math.Max(h, rc.Height);
                    }
                }

                y += h;
            }

            newpage = false;

            // now print the data for each row
            int thisNDX;
            var loopTo = dgv.RowCount - 1;
            for (thisNDX = mRow; thisNDX <= loopTo; thisNDX++)
            {
                // no need to try to print the new row
                if (dgv.Rows[thisNDX].IsNewRow)
                    break;
                row = dgv.Rows[thisNDX];
                x = e.MarginBounds.Left;
                h = 0;

                // reset X for data
                x = e.MarginBounds.Left;

                // print the data
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Visible)
                    {
                        rc = new Rectangle(x, y, cell.Size.Width, cell.Size.Height);

                        // SAMPLE CODE: How To 
                        // up a RowPrePaint rule
                        // If Convert.ToDecimal(row.Cells(5).Value) < 9.99 Then
                        // Using br As New SolidBrush(Color.MistyRose)
                        // e.Graphics.FillRectangle(br, rc)
                        // End Using
                        // End If

                        e.Graphics.DrawRectangle(Pens.Black, rc);
                        switch (dgv.Columns[cell.ColumnIndex].DefaultCellStyle.Alignment)
                        {
                            case DataGridViewContentAlignment.BottomRight:
                            case DataGridViewContentAlignment.MiddleRight:
                                {
                                    fmt.Alignment = StringAlignment.Far;
                                    rc.Offset(-1, 0);
                                    break;
                                }

                            case DataGridViewContentAlignment.BottomCenter:
                            case DataGridViewContentAlignment.MiddleCenter:
                                {
                                    fmt.Alignment = StringAlignment.Center;
                                    break;
                                }

                            default:
                                {
                                    fmt.Alignment = StringAlignment.Near;
                                    rc.Offset(2, 0);
                                    break;
                                }
                        }

                        e.Graphics.DrawString(cell.FormattedValue.ToString(), dgv.Font, Brushes.Black, rc, fmt);
                        x += rc.Width;
                        h = Math.Max(h, rc.Height);
                    }
                }

                y += h;
                // next row to print
                mRow = thisNDX + 1;
                if (y + h > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    // mRow -= 1   causes last row to rePrint on next page
                    newpage = true;
                    return;
                }
            }
        }

        private void PrintDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            mRow = 0;
            newpage = true;
            PrintPreviewDialog1.PrintPreviewControl.StartPage = 0;
            PrintPreviewDialog1.PrintPreviewControl.Zoom = 1.0d;
        }

        private System.Drawing.Printing.PrintDocument pd_PrintDoc;
        private bool PDFirstLoad = true;

        private void Button2_Click(object sender, EventArgs e)
        {
            pd_PrintDoc = PrintDocument1;
            PrintPreviewDialog1.Document = pd_PrintDoc;
            PageSetupDialog1.Document = pd_PrintDoc;
            PageSetupDialog1.EnableMetric = true;
            PrintPreviewDialog1.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            PrintPreviewDialog1.PrintPreviewControl.AutoZoom = true;
            PrintPreviewDialog1.PrintPreviewControl.Zoom = 1.1d;
            PrintPreviewDialog1.Document.DefaultPageSettings.Landscape = false;
            PrintPreviewDialog1.Document.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(79, 79, 79, 79);
            PrintPreviewDialog1.ShowIcon = true;
            PrintPreviewDialog1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PrintPreviewDialog1.WindowState = FormWindowState.Maximized;
            PrintPreviewDialog1.ShowDialog();
        }

        private void GetControlsFromDialog(object sender, EventArgs e)
        {
            if (PDFirstLoad == true)
            {
                ToolStrip ts = (ToolStrip)PrintPreviewDialog1.Controls[1];
                var PrintButtonItem = ts.Items["printToolStripButton"];
                ToolStripItem MyPrintButtonItem;
                MyPrintButtonItem = ts.Items.Add(PrintButtonItem.Text, PrintButtonItem.Image, new EventHandler(PrintDialog_Show));
                MyPrintButtonItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
                ts.Items.Insert(0, MyPrintButtonItem);
                ts.Items.Remove(PrintButtonItem);
                ToolStripItem MyPageSetupItem;
                MyPageSetupItem = ts.Items.Add("Seite einrichten", null, new EventHandler(PageDialog_Show));
                MyPageSetupItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
                ts.Items.Insert(8, MyPageSetupItem);
                PDFirstLoad = false;
            }
            else
            {
                return;
            }
        }

        private void PageDialog_Show(object sender, EventArgs e)
        {
            if (PageSetupDialog1.ShowDialog() == DialogResult.OK)
            {
                // MsgBox(PageSetupDialog1.PageSettings.Margins.ToString)

                PrintPreviewDialog1.Document = PrintDocument1;
                PrintPreviewDialog1.Document.DefaultPageSettings = PageSetupDialog1.PageSettings;

                // With PrintPreviewDialog1.Document.DefaultPageSettings
                // .Margins = PageSetupDialog1.PageSettings.Margins
                // .PaperSize = PageSetupDialog1.PageSettings.PaperSize
                // .Landscape = PageSetupDialog1.PageSettings.Landscape
                // End With
                PrintPreviewDialog1.Invalidate();
            }
            else
            {
                return;
            }
        }

        private void PrintDialog_Show(object sender, EventArgs e)
        {
            if (PrintDialog1.ShowDialog() == DialogResult.OK)
            {
                PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings;
                PrintDialog1.Document = PrintDocument1;
                PrintDialog1.Document.Print();
            }
        }
    }
}