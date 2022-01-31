using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GSB
{
    public abstract class GestionsDates 
    {
        public static string GetMoisPrecedent()
        {
            try
            {
                int date = DateTime.Today.Month;
                if (date == 1)
                {
                    date = 12;
                }
                else
                {
                    date -= 1;
                }
                return (date.ToString("D2"));


            }
            catch (Exception ex)
            {
                return (ex.Message);
            }
        }

        public static string GetMoisPrecedent(DateTime date)
        {
            try
            {
                int mois = date.Month;
                int moisPrdt = 0;
                if (mois == 1)
                {
                    moisPrdt = 12;
                }
                else
                {
                    moisPrdt = date.Month - 1;
                }
                return (moisPrdt.ToString("D2"));
            }
            catch (Exception ex)
            {
                return (ex.Message);
            }
        }   

        public static string GetMoisSuivant()
        {
            try
            {
                int date = DateTime.Today.Month;
                if (date == 12)
                {
                    date = 1;
                }
                else
                {
                    date += 1;
                }
                return (date.ToString("D2"));
            }
            catch (Exception ex)
            {
                return (ex.Message);
            }
        }

        public static string GetMoisSuivant(DateTime date)
        {
            try
            {
                int mois = date.Month;
                int GetMoisSuivant = 0;
                if (mois == 12)
                {
                    GetMoisSuivant = 1;
                }
                else
                {
                    GetMoisSuivant = mois + 1;
                }
                return GetMoisSuivant.ToString("D2");
            }
            catch (Exception ex)
            {
                return (ex.Message);
            }
        }

        public static string Entre(int date1, int date2)
        {
            try
            {
                int jourActuelle = DateTime.Now.Day;
                if (date1 < jourActuelle & jourActuelle < date2)
                {
                    return ("La date du jour est entre.");
                }
                else
                {
                    return ("La date du jour est à l'extérieur.");
                }
            }
            catch (Exception ex)
            {
                return (ex.Message);
            }
        }

        public static string Entre(int date1, int date2, int date3)
        {
            try {
                int jourActuelle = date3;
                if (date1 < date3 & date3 < date2)
                {
                    return ("La date du jour est entre.");
                }
                else
                {
                    return ("La date du jour est à l'extérieur.");
                }
            }
            catch (Exception ex)
            {
                return (ex.Message);
            }
        }
    }
}
