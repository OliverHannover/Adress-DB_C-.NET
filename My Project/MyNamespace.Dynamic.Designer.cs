using System;
using System.ComponentModel;
using System.Diagnostics;

namespace Adress_DB.My
{
    internal static partial class MyProject
    {
        internal partial class MyForms
        {
            [EditorBrowsable(EditorBrowsableState.Never)]
            public AboutBox1 m_AboutBox1;

            public AboutBox1 AboutBox1
            {
                [DebuggerHidden]
                get
                {
                    m_AboutBox1 = Create__Instance__(m_AboutBox1);
                    return m_AboutBox1;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_AboutBox1))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_AboutBox1);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Administration m_Administration;

            public Administration Administration
            {
                [DebuggerHidden]
                get
                {
                    m_Administration = Create__Instance__(m_Administration);
                    return m_Administration;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Administration))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Administration);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Form3 m_Form3;

            public Form3 Form3
            {
                [DebuggerHidden]
                get
                {
                    m_Form3 = Create__Instance__(m_Form3);
                    return m_Form3;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Form3))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Form3);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Hauptform m_Hauptform;

            public Hauptform Hauptform
            {
                [DebuggerHidden]
                get
                {
                    m_Hauptform = Create__Instance__(m_Hauptform);
                    return m_Hauptform;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Hauptform))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Hauptform);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public KontoForm m_KontoForm;

            public KontoForm KontoForm
            {
                [DebuggerHidden]
                get
                {
                    m_KontoForm = Create__Instance__(m_KontoForm);
                    return m_KontoForm;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_KontoForm))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_KontoForm);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Loginformationen m_Loginformationen;

            public Loginformationen Loginformationen
            {
                [DebuggerHidden]
                get
                {
                    m_Loginformationen = Create__Instance__(m_Loginformationen);
                    return m_Loginformationen;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Loginformationen))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Loginformationen);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Personensuche m_Personensuche;

            public Personensuche Personensuche
            {
                [DebuggerHidden]
                get
                {
                    m_Personensuche = Create__Instance__(m_Personensuche);
                    return m_Personensuche;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Personensuche))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Personensuche);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Sachbearbeiter m_Sachbearbeiter;

            public Sachbearbeiter Sachbearbeiter
            {
                [DebuggerHidden]
                get
                {
                    m_Sachbearbeiter = Create__Instance__(m_Sachbearbeiter);
                    return m_Sachbearbeiter;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Sachbearbeiter))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Sachbearbeiter);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public SplashScreen1 m_SplashScreen1;

            public SplashScreen1 SplashScreen1
            {
                [DebuggerHidden]
                get
                {
                    m_SplashScreen1 = Create__Instance__(m_SplashScreen1);
                    return m_SplashScreen1;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_SplashScreen1))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_SplashScreen1);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Umkreissuche m_Umkreissuche;

            public Umkreissuche Umkreissuche
            {
                [DebuggerHidden]
                get
                {
                    m_Umkreissuche = Create__Instance__(m_Umkreissuche);
                    return m_Umkreissuche;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Umkreissuche))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Umkreissuche);
                }
            }
        }
    }
}