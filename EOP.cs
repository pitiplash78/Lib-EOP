using System;
using System.IO;
using System.Xml.Serialization;
using Units;

namespace EOP
{
    /// <summary>
    /// Class containg all knwon EOP values.
    /// </summary>
    [XmlRoot("EOP")]
    public class EOP
    {
        /// <summary>
        /// Constructor of the EOP class.
        /// </summary>
        public EOP()
        { }

        #region Base units
        /// <summary>
        /// Units of the according values related to the Units class.
        /// </summary>
        public static class BaseUnits
        {
            public static readonly Units.Units.UnitNamesEnum PolCoordinateVariations = Units.Units.UnitNamesEnum.ArcSecond;
            public static readonly Units.Units.UnitNamesEnum LoDVariations = Units.Units.UnitNamesEnum.Second;

            public static readonly Units.Units.UnitNamesEnum X = Units.Units.UnitNamesEnum.ArcSecond;
            public static readonly Units.Units.UnitNamesEnum Y = Units.Units.UnitNamesEnum.ArcSecond;
            public static readonly Units.Units.UnitNamesEnum UT1_UTC = Units.Units.UnitNamesEnum.Second;
            public static readonly Units.Units.UnitNamesEnum LOD = Units.Units.UnitNamesEnum.Second;
            public static readonly Units.Units.UnitNamesEnum dPsi = Units.Units.UnitNamesEnum.ArcSecond;
            public static readonly Units.Units.UnitNamesEnum dEps = Units.Units.UnitNamesEnum.ArcSecond;
            public static readonly Units.Units.UnitNamesEnum X_Err = Units.Units.UnitNamesEnum.ArcSecond;
            public static readonly Units.Units.UnitNamesEnum Y_Err = Units.Units.UnitNamesEnum.ArcSecond;
            public static readonly Units.Units.UnitNamesEnum UT1_UTC_Err = Units.Units.UnitNamesEnum.Second;
            public static readonly Units.Units.UnitNamesEnum LOD_Err = Units.Units.UnitNamesEnum.Second;
            public static readonly Units.Units.UnitNamesEnum dPsi_Err = Units.Units.UnitNamesEnum.ArcSecond;
            public static readonly Units.Units.UnitNamesEnum dEps_Err = Units.Units.UnitNamesEnum.ArcSecond;
        }
        #endregion

        /// <summary>
        /// Time tag for knowing the last update of the data.
        /// </summary>
        [XmlElement("lastUpDate")]
        public DateTime lastUpDate;

        /// <summary>
        /// Time tag for knowing the last LOD value of the data.
        /// </summary>
        [XmlElement("lastLOD_Value")]
        public DateTime lastLOD_Value;

        #region C04_modified
        /// <summary>
        /// Object, which contains the data combined for the IERS C04 time sries and the UNSO rapird solution.
        /// </summary>
        [XmlElement("C04_Modified")]
        public C04_Modified[] C04_modified = null;

        /// <summary>
        /// Class, which contains the combined data for the IERS C04 time sries and the UNSO rapird solution.
        /// </summary>
        public class C04_Modified
        {
            /// <summary>
            /// Time of the according data in modifed Julian day format.
            /// </summary>
            [XmlAttribute("MJD")]
            public double MJD;

            /// <summary>
            /// Time of the according data.
            /// </summary>
            [XmlAttribute("Time")]
            public DateTime Time;

            /// <summary>
            /// X pole value [as].
            /// </summary>
            [XmlAttribute("X")]
            public double X;

            /// <summary>
            /// Y pole value [as].
            /// </summary>
            [XmlAttribute("Y")]
            public double Y;

            /// <summary>
            /// Value for UT1-UTC [s].
            /// </summary>
            [XmlAttribute("UT1_UTC")]
            public double UT1_UTC;

            /// <summary>
            /// Value for TAI-UT1 [s] (Calculated from UT1-UTC minus the related actual leap second).
            /// </summary>
            [XmlAttribute("TAI_UT1")]
            public double TAI_UT1;

            /// <summary>
            /// Value for lenght of day [s]. 
            /// </summary>
            [XmlAttribute("LOD")]
            public double LOD;

            /// <summary>
            /// Contstructor of the class, which contains the combined data for the IERS C04 time sries and the UNSO rapird solution.
            /// </summary>
            public C04_Modified()
            { }

            /// <summary>
            /// Contstructor of the class, which contains the combined data for the IERS C04 time sries and the UNSO rapird solution.
            /// </summary>
            /// <param name="MJD">Time of the according data in modifed Julian day format.</param>
            /// <param name="Time">Time of the according data.</param>
            /// <param name="X">X pole value [as].</param>
            /// <param name="Y">Y pole value [as].</param>
            /// <param name="UT1_UTC">Value for UT1-UTC [s].</param>
            /// <param name="TAI_UT1">Value for TAI-UT1 [s] (Calculated from UT1-UTC minus the related actual leap second).</param>
            /// <param name="LOD">Value for lenght of day [s].</param>
            public C04_Modified(double MJD, DateTime Time, double X, double Y, double UT1_UTC, double TAI_UT1, double LOD)
            {
                this.MJD = MJD;
                this.Time = Time;
                this.X = X;
                this.Y = Y;
                this.UT1_UTC = UT1_UTC;
                this.TAI_UT1 = TAI_UT1;
                this.LOD = LOD;
            }
        }
        #endregion

        #region RapidSolution_C04
        /// <summary>
        /// Temporary object, which contains the data for the UNSO rapird solution (used for reading the downloaded file).
        /// </summary>
        [XmlIgnore()]
        public RapidSolution_C04[] RapidSolution_c04TMP = null;

        /// <summary>
        /// Object, which contains the data for the UNSO rapird solution.
        /// </summary>
        [XmlElement("RapidSolution_c04")]
        public RapidSolution_C04[] RapidSolution_c04 = null;

        /// <summary>
        /// Class, which contains the data for the UNSO rapird solution.
        /// </summary>
        public class RapidSolution_C04
        {
            /// <summary>
            /// Time of the according data in modifed Julian day format.
            /// </summary>
            [XmlAttribute("MJD")]
            public double MJD;

            /// <summary>
            /// Time of the according data.
            /// </summary>
            [XmlAttribute("Time")]
            public DateTime Time;

            /// <summary>
            /// X pole value [as].
            /// </summary>
            [XmlAttribute("X")]
            public double X;

            /// <summary>
            /// Y pole value [as].
            /// </summary>
            [XmlAttribute("Y")]
            public double Y;

            /// <summary>
            /// Value for UT1-UTC [s].
            /// </summary>
            [XmlAttribute("UT1_UTC")]
            public double UT1_UTC;

            /// <summary>
            /// Value for lenght of day [s].
            /// </summary>
            [XmlAttribute("LOD")]
            public double LOD;

            /// <summary>
            /// Flag given the mark, if the avvording values are predicted or determined be the data.
            /// </summary>
            [XmlAttribute("Prediction")]
            public bool Prediction;

            /// <summary>
            /// Constructor, which contains the data for the UNSO rapird solution.
            /// </summary>
            public RapidSolution_C04()
            { }

            /// <summary>
            /// Constructor, which contains the data for the UNSO rapird solution.
            /// </summary>
            /// <param name="MJD">Time of the according data in modifed Julian day format.</param>
            /// <param name="Time">Time of the according data.</param>
            /// <param name="X">X pole value [as].</param>
            /// <param name="Y">Y pole value [as].</param>
            /// <param name="UT1_UTC">Value for UT1-UTC [s].</param>
            /// <param name="LOD">Value for lenght of day [s].</param>
            /// <param name="Prediction">Flag given the mark, if the avvording values are predicted or determined be the data.</param>
            public RapidSolution_C04(double MJD, DateTime Time, double X, double Y, double UT1_UTC, double LOD, bool Prediction)
            {
                this.MJD = MJD;
                this.Time = Time;
                this.X = X;
                this.Y = Y;
                this.UT1_UTC = UT1_UTC;
                this.LOD = LOD;
                this.Prediction = Prediction;
            }
        }

        /// <summary>
        /// Analyses the file 'finals.data' from UNSO.
        /// </summary>
        /// <param name="path">Path of the file.</param>
        /// <param name="adress">Address of the host, where the file to be analyses are found.</param>
        /// <param name="message">Error message, if something was going wrong on reading.</param>
        /// <returns>Returns the the object for 'RapidSolution_C04' (favorable is used the temporary object)</returns>
        public RapidSolution_C04[] analyseFileRapidC04_old(string path, string adress, ref string message)
        {
            RapidSolution_C04[] c04 = null;
            System.Collections.ArrayList tmp = new System.Collections.ArrayList();
            string str = null;

            char[] delimeter = new char[] { ' ', '\t', 'I', 'P' };
            string[] parts = null;
            StreamReader reader = null;

            try
            {
                reader = new StreamReader(new FileStream(path, FileMode.Open));
                while ((str = reader.ReadLine()) != null)
                {
                    if (str.Length > 6)
                        str = str.Remove(0, 6);
                    parts = str.Split(delimeter, StringSplitOptions.RemoveEmptyEntries);
                    double mjd, x, y, UT1_UTC, LOD, prediction = double.NaN;

                    if (str.Contains("P"))
                        prediction = 1.0;
                    else
                        prediction = 0.0;

                    if (parts != null && parts.Length > 13 && 
                        double.TryParse(parts[0], System.Globalization.NumberStyles.Any, Constants.NumberFormatEN, out mjd) &&
                        double.TryParse(parts[1], System.Globalization.NumberStyles.Any, Constants.NumberFormatEN, out x) &&
                        double.TryParse(parts[3], System.Globalization.NumberStyles.Any, Constants.NumberFormatEN, out y) &&
                        double.TryParse(parts[5], System.Globalization.NumberStyles.Any, Constants.NumberFormatEN, out UT1_UTC) &&
                        double.TryParse(parts[7], System.Globalization.NumberStyles.Any, Constants.NumberFormatEN, out LOD))
                    {
                        DateTime dt = TimeConversion.TimeConversion.ModJulDay2Time(mjd);
                        tmp.Add(new double[9] { dt.Year, dt.Month, dt.Day, mjd, x, y, UT1_UTC, LOD / 1000.0, prediction });
                    }
                }
                reader.Close();

                c04 = new RapidSolution_C04[tmp.Count];
                for (int i = 0; i < tmp.Count; i++)
                {
                    double[] t = (double[])tmp[i];
                    c04[i] = new RapidSolution_C04(t[3], new DateTime((int)t[0], (int)t[1], (int)t[2], 0, 0, 0), t[4], t[5], t[6], t[7], Convert.ToBoolean(t[8]));
                }
            }
            catch (Exception ex)
            {
                if(reader != null)
                    reader.Close();
                c04 = null;
                message += "Error on analysis of the rapid solution from:" + Environment.NewLine +
                           " " + adress + Environment.NewLine +
                           "System Error:" + ex.Message + Environment.NewLine;
            }
            return c04;
        }

        public RapidSolution_C04[] analyseFileRapidC04(string path, string adress, ref string message)
        {
            RapidSolution_C04[] c04 = null;
            System.Collections.ArrayList tmp = new System.Collections.ArrayList();
            string str = null;

            StreamReader reader = null;

            try
            {
                reader = new StreamReader(new FileStream(path, FileMode.Open));
                while ((str = reader.ReadLine()) != null)
                {
                    if (str.Length > 6)
                        str = str.Remove(0, 6);

                    double result = double.NaN;

                    double mjd = double.NaN;
                    if (str.Length >= 9)
                    {
                        string stmp = str.Substring(0, 9);
                        double.TryParse(stmp, System.Globalization.NumberStyles.Any, Constants.NumberFormatEN, out result);
                        if (result == 0.0)
                            mjd = double.NaN;
                        else
                            mjd = result;
                    }

                    double x = double.NaN;
                    if (str.Length >= 21)
                    {
                        string stmp = str.Substring(11, 10);
                        double.TryParse(stmp, System.Globalization.NumberStyles.Any, Constants.NumberFormatEN, out result);
                        if (result == 0.0)
                            x = double.NaN;
                        else
                            x = result;
                    }

                    double y = double.NaN;
                    if (str.Length >= 40)
                    {
                        string stmp = str.Substring(30, 10);
                        double.TryParse(stmp, System.Globalization.NumberStyles.Any, Constants.NumberFormatEN, out result);
                        if (result == 0.0)
                            y = double.NaN;
                        else
                            y = result;
                    }

                    double UT1_UTC = double.NaN;
                    if (str.Length >= 62)
                    {
                        string stmp = str.Substring(52, 10);
                        double.TryParse(stmp, System.Globalization.NumberStyles.Any, Constants.NumberFormatEN, out result);
                        if (result == 0.0)
                            UT1_UTC = double.NaN;
                        else
                            UT1_UTC = result;
                    }

                    double LOD = double.NaN;
                    if (str.Length >= 80)
                    {
                        string stmp = str.Substring(72, 8);
                        double.TryParse(stmp, System.Globalization.NumberStyles.Any, Constants.NumberFormatEN, out result);
                        if (result == 0.0)
                            LOD = double.NaN;
                        else
                            LOD = result;
                    }

                    double prediction = double.NaN;
                    if (str.Contains("P"))
                        prediction = 1.0;
                    else
                        prediction = 0.0;

                    if(!double.IsNaN(mjd) && !double.IsNaN(x) && !double.IsNaN(y) && !double.IsNaN(UT1_UTC))
                    {
                        DateTime dt = TimeConversion.TimeConversion.ModJulDay2Time(mjd);
                        tmp.Add(new double[9] { dt.Year, dt.Month, dt.Day, mjd, x, y, UT1_UTC, LOD / 1000.0, prediction });
                    }
                }
                reader.Close();

                c04 = new RapidSolution_C04[tmp.Count];
                for (int i = 0; i < tmp.Count; i++)
                {
                    double[] t = (double[])tmp[i];
                    c04[i] = new RapidSolution_C04(t[3], new DateTime((int)t[0], (int)t[1], (int)t[2], 0, 0, 0), t[4], t[5], t[6], t[7], Convert.ToBoolean(t[8]));
                }
            }
            catch (Exception ex)
            {
                if (reader != null)
                    reader.Close();
                c04 = null;
                message += "Error on analysis of the rapid solution from:" + Environment.NewLine +
                           " " + adress + Environment.NewLine +
                           "System Error:" + ex.Message + Environment.NewLine;
            }
            return c04;
        }

        
        #endregion

        #region IERS_C04
        /// <summary>
        /// Temporary object, which contains the data for the IERS C04 time sries.
        /// </summary>
        [XmlIgnore()]
        public IERS_C04[] IERS_c04TMP = null;

        /// <summary>
        /// Object, which contains the data for the IERS C04 time sries.
        /// </summary>
        [XmlElement("IERS_c04")]
        public IERS_C04[] IERS_c04 = null;

        /// <summary>
        /// Class, which contains the data for the IERS C04 time sries.
        /// </summary>
        public class IERS_C04
        {
            /// <summary>
            /// Time of the according data in modifed Julian day format.
            /// </summary>
            [XmlAttribute("MJD")]
            public double MJD;

            /// <summary>
            /// Time of the according data.
            /// </summary>
            [XmlAttribute("Time")]
            public DateTime Time;

            /// <summary>
            /// X pole value [as].
            /// </summary>
            [XmlAttribute("X")]
            public double X;

            /// <summary>
            /// Y pole value [as].
            /// </summary>
            [XmlAttribute("Y")]
            public double Y;

            /// <summary>
            /// Value for UT1-UTC [s].
            /// </summary>
            [XmlAttribute("UT1_UTC")]
            public double UT1_UTC;

            /// <summary>
            /// Value for lenght of day [s].
            /// </summary>
            [XmlAttribute("LOD")]
            public double LOD;

            /// <summary>
            /// Celestial pole offset in X direction [as].
            /// </summary>
            [XmlAttribute("dPsi")]
            public double dPsi;

            /// <summary>
            /// Celestial pole offset in Y direction [as].
            /// </summary>
            [XmlAttribute("dEps")]
            public double dEps;

            /// <summary>
            /// Error for X pole value [as].
            /// </summary>
            [XmlAttribute("X_Err")]
            public double X_Err;

            /// <summary>
            /// Error for Y pole value [as].
            /// </summary>
            [XmlAttribute("Y_Err")]
            public double Y_Err;

            /// <summary>
            /// Error for UT1-UTC [s].
            /// </summary>
            [XmlAttribute("UT1_UTC_Err")]
            public double UT1_UTC_Err;

            /// <summary>
            /// Error for lenght of day [s].
            /// </summary>
            [XmlAttribute("LOD_Err")]
            public double LOD_Err;

            /// <summary>
            /// Error for celestial pole offset in X direction [as].
            /// </summary>
            [XmlAttribute("dPsi_Err")]
            public double dPsi_Err;

            /// <summary>
            /// Error for celestial pole offset in Y direction [as].
            /// </summary>
            [XmlAttribute("dEps_Err")]
            public double dEps_Err;

            /// <summary>
            /// Contstructor of the class, which contains the data for the IERS C04 time sries.
            /// </summary>
            public IERS_C04()
            { }

            /// <summary>
            /// Contstructor of the class, which contains the data for the IERS C04 time sries.
            /// </summary>
            /// <param name="MJD">Time of the according data in modifed Julian day format.</param>
            /// <param name="Time">Time of the according data.</param>
            /// <param name="X">X pole value [as].</param>
            /// <param name="Y">Y pole value [as].</param>
            /// <param name="UT1_UTC">Value for UT1-UTC [s].</param>
            /// <param name="LOD">Value for lenght of day [s].</param>
            /// <param name="dPsi">Celestial pole offset in X direction.</param>
            /// <param name="dEps">Celestial pole offset in Y direction.</param>
            /// <param name="X_Err">Error for X pole value [as].</param>
            /// <param name="Y_Err">Error for Y pole value [as].</param>
            /// <param name="UT1_UTC_Err">Error for UT1-UTC [s].</param>
            /// <param name="LOD_Err">Error for lenght of day [s].</param>
            /// <param name="dPsi_Err">Error for celestial pole offset in X direction.</param>
            /// <param name="dEps_Err">Error for celestial pole offset in Y direction.</param>
            public IERS_C04(double MJD, DateTime Time, double X, double Y, double UT1_UTC, double LOD, double dPsi, double dEps, double X_Err, double Y_Err, double UT1_UTC_Err, double LOD_Err, double dPsi_Err, double dEps_Err)
            {
                this.MJD = MJD;
                this.Time = Time;
                this.X = X;
                this.Y = Y;
                this.UT1_UTC = UT1_UTC;
                this.LOD = LOD;
                this.dPsi = dPsi;
                this.dEps = dEps;
                this.X_Err = X_Err;
                this.Y_Err = Y_Err;
                this.UT1_UTC_Err = UT1_UTC_Err;
                this.LOD_Err = LOD_Err;
                this.dPsi_Err = dPsi_Err;
                this.dEps_Err = dEps_Err;
            }
        }

        /// <summary>
        /// Analyses the file 'eopc04.62-now' from IERS.
        /// </summary>
        /// <param name="path">Path of the file.</param>
        /// <param name="adress">Address of the host, where the file to be analyses are found.</param>
        /// <param name="message">Error message, if something was going wrong on reading.</param>
        /// <returns>Returns the the object for 'IERS_C04' (favorable is used the temporary object)</returns>
        public IERS_C04[] analyseFileC04(string path, string adress, ref string message)
        {
            IERS_C04[] c04 = null;
            System.Collections.ArrayList tmp = new System.Collections.ArrayList();
            string str = null;

            char[] delimeter = new char[] { ' ', '\t' };
            string[] parts = null;

            try
            {
                StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open));
                while ((str = reader.ReadLine()) != null)
                {
                    parts = str.Split(delimeter, StringSplitOptions.RemoveEmptyEntries);
                    double year = double.NaN;
                    double month = double.NaN;
                    double day = double.NaN;
                    double mjd = double.NaN;
                    double x = double.NaN;
                    double y = double.NaN;
                    double UT1_UTC = double.NaN;
                    double LOD = double.NaN;
                    double dPsi = double.NaN;
                    double dEps = double.NaN;
                    double xErr = double.NaN;
                    double yErr = double.NaN;
                    double UT1_UTCerr = double.NaN;
                    double LODerr = double.NaN;
                    double dPsierr = double.NaN;
                    double dEpserr = double.NaN;

                    if (parts != null && parts.Length == 16 &&
                        double.TryParse(parts[0], System.Globalization.NumberStyles.Any, Constants.NumberFormatEN, out year) &&
                        double.TryParse(parts[1], System.Globalization.NumberStyles.Any, Constants.NumberFormatEN, out month) &&
                        double.TryParse(parts[2], System.Globalization.NumberStyles.Any, Constants.NumberFormatEN, out day) &&
                        double.TryParse(parts[3], System.Globalization.NumberStyles.Any, Constants.NumberFormatEN, out mjd) &&
                        double.TryParse(parts[4], System.Globalization.NumberStyles.Any, Constants.NumberFormatEN, out x) &&
                        double.TryParse(parts[5], System.Globalization.NumberStyles.Any, Constants.NumberFormatEN, out y) &&
                        double.TryParse(parts[6], System.Globalization.NumberStyles.Any, Constants.NumberFormatEN, out UT1_UTC) &&
                        double.TryParse(parts[7], System.Globalization.NumberStyles.Any, Constants.NumberFormatEN, out LOD) &&
                        double.TryParse(parts[8], System.Globalization.NumberStyles.Any, Constants.NumberFormatEN, out dPsi) &&
                        double.TryParse(parts[9], System.Globalization.NumberStyles.Any, Constants.NumberFormatEN, out dEps) &&
                        double.TryParse(parts[10], System.Globalization.NumberStyles.Any, Constants.NumberFormatEN, out xErr) &&
                        double.TryParse(parts[11], System.Globalization.NumberStyles.Any, Constants.NumberFormatEN, out yErr) &&
                        double.TryParse(parts[12], System.Globalization.NumberStyles.Any, Constants.NumberFormatEN, out UT1_UTCerr) &&
                        double.TryParse(parts[13], System.Globalization.NumberStyles.Any, Constants.NumberFormatEN, out LODerr) &&
                        double.TryParse(parts[14], System.Globalization.NumberStyles.Any, Constants.NumberFormatEN, out dPsierr) &&
                        double.TryParse(parts[15], System.Globalization.NumberStyles.Any, Constants.NumberFormatEN, out dEpserr))
                        tmp.Add(new double[16] { year, month, day, mjd, x, y, UT1_UTC, LOD, dPsi, dEps, xErr, yErr, UT1_UTCerr, LODerr, dPsierr, dEpserr });
                }
                reader.Close();

                c04 = new IERS_C04[tmp.Count];
                for (int i = 0; i < tmp.Count; i++)
                {
                    double[] t = (double[])tmp[i];
                    c04[i] = new IERS_C04(t[3], new DateTime((int)t[0], (int)t[1], (int)t[2], 0, 0, 0), t[4], t[5], t[6], t[7], t[8], t[9], t[10], t[11], t[12], t[13], t[14], t[15]);
                }

            }
            catch (Exception ex)
            {
                c04 = null;
                message += "Error on analysis of the Earth orientation paramerter (C04) from:" + Environment.NewLine +
                           " " + adress + Environment.NewLine +
                           "System Error:" + ex.Message + Environment.NewLine;
            }
            return c04;
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ErrorMessage"></param>
        /// <param name="leapSecond"></param>
        public void combineDataSets(ref string ErrorMessage, TimeConversion.LeapSecond leapSecond)
        {
            ErrorMessage = null;
            if ((IERS_c04 == null || IERS_c04.Length == 0) &&
               (RapidSolution_c04 == null || RapidSolution_c04.Length == 0) &&
               (leapSecond.leapSecond == null || leapSecond.leapSecond.Length == 0))
            {
                ErrorMessage = "The combination of the IERS C04 time series and the rapid solution was not possible!";
                return;
            }

            int length = 0;
            int lengthIERS = IERS_c04.Length;
            int lengthRapidAdditional = 0;
            if (IERS_c04[IERS_c04.Length - 1].MJD < RapidSolution_c04[RapidSolution_c04.Length - 1].MJD)
                lengthRapidAdditional += (int)(RapidSolution_c04[RapidSolution_c04.Length - 1].MJD - IERS_c04[IERS_c04.Length - 1].MJD);

            length = lengthIERS + lengthRapidAdditional;
            C04_modified = new EOP.C04_Modified[length];

            // C04 from IERS
            for (int i = 0; i < lengthIERS; i++)
            {
                double TAI_UT1 = 10.0 - IERS_c04[i].UT1_UTC;
                for (int j = 0; j < leapSecond.leapSecond.Length; j++)
                    if (IERS_c04[i].MJD >= leapSecond.leapSecond[j].MJD)
                        TAI_UT1 = leapSecond.leapSecond[j].TAI_UTC - IERS_c04[i].UT1_UTC;

                C04_modified[i] = new EOP.C04_Modified(IERS_c04[i].MJD, IERS_c04[i].Time, IERS_c04[i].X, IERS_c04[i].Y, IERS_c04[i].UT1_UTC, TAI_UT1, IERS_c04[i].LOD);
            }

            // find positions for rapid solution
            int startRapidSolution = RapidSolution_c04.Length - lengthRapidAdditional;

            // "C04" from UNSO - rapid solutions
            bool lastLOD = false;
            for (int i = lengthIERS; i < length; i++)
            {
                int index = i - lengthIERS + startRapidSolution;

                double TAI_UT1 = 10.0 - RapidSolution_c04[index].UT1_UTC;
                for (int j = 0; j < leapSecond.leapSecond.Length; j++)
                    if (RapidSolution_c04[index].MJD >= leapSecond.leapSecond[j].MJD)
                        TAI_UT1 = leapSecond.leapSecond[j].TAI_UTC - RapidSolution_c04[index].UT1_UTC;

                double LOD = RapidSolution_c04[index].LOD;

                if(double.IsNaN(LOD))
                {
                    if (!lastLOD)
                    {
                        lastLOD_Value = RapidSolution_c04[index - 1].Time;
                        lastLOD = true;
                    }

                    LOD = 0.0;
                }

                C04_modified[i] = new EOP.C04_Modified(RapidSolution_c04[index].MJD, RapidSolution_c04[index].Time,
                    RapidSolution_c04[index].X, RapidSolution_c04[index].Y, RapidSolution_c04[index].UT1_UTC, TAI_UT1, LOD);
            }
        }

        public void combineDataSets2(ref string ErrorMessage, TimeConversion.LeapSecond leapSecond)
        {
            ErrorMessage = null;
            if ((IERS_c04 == null || IERS_c04.Length == 0) &&
               (RapidSolution_c04 == null || RapidSolution_c04.Length == 0) &&
               (leapSecond.leapSecond == null || leapSecond.leapSecond.Length == 0))
            {
                ErrorMessage = "The combination of the IERS C04 time series and the rapid solution was not possible!";
                return;
            }

            int length = 0;
            int lengthIERS = IERS_c04.Length;
            int lengthRapidAdditional = 0;
            if (IERS_c04[IERS_c04.Length - 1].MJD < RapidSolution_c04[RapidSolution_c04.Length - 1].MJD)
                lengthRapidAdditional += (int)(RapidSolution_c04[RapidSolution_c04.Length - 1].MJD - IERS_c04[IERS_c04.Length - 1].MJD);

            length = lengthIERS + lengthRapidAdditional;
            C04_modified = new EOP.C04_Modified[length];

            // C04 from IERS
            for (int i = 0; i < lengthIERS; i++)
            {
                double TAI_UT1 = 10.0 - IERS_c04[i].UT1_UTC;
                for (int j = 0; j < leapSecond.leapSecond.Length; j++)
                    if (IERS_c04[i].MJD >= leapSecond.leapSecond[j].MJD)
                        TAI_UT1 = leapSecond.leapSecond[j].TAI_UTC - IERS_c04[i].UT1_UTC;

                C04_modified[i] = new EOP.C04_Modified(IERS_c04[i].MJD, IERS_c04[i].Time, IERS_c04[i].X, IERS_c04[i].Y, IERS_c04[i].UT1_UTC, TAI_UT1, IERS_c04[i].LOD);
            }

            // find positions for rapid solution
            int startRapidSolution = RapidSolution_c04.Length - lengthRapidAdditional;

            // "C04" from UNSO - rapid solutions
            for (int i = lengthIERS; i < length; i++)
            {
                int index = i - lengthIERS + startRapidSolution;

                double TAI_UT1 = 10.0 - RapidSolution_c04[index].UT1_UTC;
                for (int j = 0; j < leapSecond.leapSecond.Length; j++)
                    if (RapidSolution_c04[index].MJD >= leapSecond.leapSecond[j].MJD)
                        TAI_UT1 = leapSecond.leapSecond[j].TAI_UTC - RapidSolution_c04[index].UT1_UTC;

                C04_modified[i] = new EOP.C04_Modified(RapidSolution_c04[index].MJD, RapidSolution_c04[index].Time,
                    RapidSolution_c04[index].X, RapidSolution_c04[index].Y, RapidSolution_c04[index].UT1_UTC, TAI_UT1, RapidSolution_c04[index].LOD);
            }
        }

        #region Old Eterna output - obsolete
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pathOutput"></param>
        /// <param name="addressEOPC04"></param>
        public void writeC04Combined(string pathOutput, string addressEOPC04)
        {
            StreamWriter writer = new StreamWriter(new FileStream(pathOutput, FileMode.Create));
            writer.Write(string.Format(Constants.NumberFormatEN, FormatStringHeaderEtPolUt1,
                DateTime.Now.ToString("yyyy.MM.dd"),
                Path.GetFileName(addressEOPC04),
                addressEOPC04,
                C04_modified[0].Time.ToString("yyyy.MM.dd"), C04_modified[0].MJD,
                C04_modified[C04_modified.Length - 1].Time.ToString("yyyy.MM.dd"), C04_modified[C04_modified.Length - 1].MJD,
                (C04_modified[C04_modified.Length - 1].Time - C04_modified[0].Time).Days,
                (C04_modified[C04_modified.Length - 1].Time - C04_modified[0].Time).Days / 356.25));

            for (int i = 0; i < C04_modified.Length; i++)
            {
                writer.WriteLine(string.Format(Constants.NumberFormatEN,
                    "{0,4:0000}{1,2:00}{2,2:00} 000000{3,10:0.000}{4,10:0.00000}{5,10:0.00000}{6,10:0.000000}{7,10:0.000000}",
                    C04_modified[i].Time.Year, C04_modified[i].Time.Month, C04_modified[i].Time.Day,
                    C04_modified[i].MJD,
                    C04_modified[i].X, C04_modified[i].Y, C04_modified[i].UT1_UTC, C04_modified[i].TAI_UT1));
            }
            writer.WriteLine("99999999");
            writer.Flush();
            writer.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        internal static string FormatStringHeaderEtPolUt1 = "FILE     : ETPOLUT1.DAT" + Environment.NewLine +
                                                           "STATUS   : {0}" + Environment.NewLine + // 1997.09.04                                       
                                                           "CONTENTS : Pole coordinates and earth rotation," + Environment.NewLine +
                                                           "           one day sampling interval, given at 0 hours UTC." + Environment.NewLine + Environment.NewLine +
                                                           "           The pole coordinates, UT1-UTC and TAI-UT1 have been taken from" + Environment.NewLine +
                                                           "           file {1}" + Environment.NewLine + Environment.NewLine +
                                                           "           INTERNET adress: {2}" + Environment.NewLine + Environment.NewLine +
                                                           "           International Earth Rotation Service" + Environment.NewLine +
                                                           "           Central Bureau (IERS/CB)" + Environment.NewLine +
                                                           "           Observatoire de Paris" + Environment.NewLine +
                                                           "           61, avenue de l'Observatoire" + Environment.NewLine +
                                                           "           F-75014 PARIS" + Environment.NewLine +
                                                           "           France" + Environment.NewLine +
                                                           "           e-mail: iers@obspm.fr" + Environment.NewLine + Environment.NewLine +
                                                           "           Start: {3,10}  MJD = {4,9:0.000}" + Environment.NewLine + Environment.NewLine +
                                                           "           End  : {5,10}  MJD = {6,9:0.000}" + Environment.NewLine + Environment.NewLine + Environment.NewLine +
                                                           "           Span :                   {7,9:0.000} days  = {8,6:0.00} years" + Environment.NewLine + Environment.NewLine + Environment.NewLine +
                                                           "Date     Time    MJD          x         y       UT1-UTC   TAI-UT1" + Environment.NewLine + Environment.NewLine +
                                                           "                             [\"]       [\"]      [SEC]     [SEC]" + Environment.NewLine + Environment.NewLine +
                                                           "C******************************************************************************" + Environment.NewLine;
        #endregion

        /// <summary>
        /// Serialisation of EOP class to XML.
        /// </summary>
        /// <param name="eop"></param>
        public static void serialisieren(EOP eop, string path)
        {
            XmlSerializer s = new XmlSerializer(typeof(EOP));
            TextWriter w = new StreamWriter(path);
            s.Serialize(w, eop);
            w.Close();
        }

        /// <summary>
        /// Deserialisation of EOP class From XML.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static EOP deserialisieren(string path)
        {
            EOP eop;

            XmlSerializer s = new XmlSerializer(typeof(EOP));
            TextReader r = new StreamReader(path);
            eop = (EOP)s.Deserialize(r);
            r.Close();
            return eop;
        }
    }
}
