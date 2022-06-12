using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace server
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        private ii_t2Entities ii_T2Entities = new ii_t2Entities();

        [WebMethod]
        public void Add(String Name, String Description, int Players, int Trophies, long Value)
        {
            Football_Teams ft = new Football_Teams();
            ft = ii_T2Entities.Football_Teams.Where(x => x.Name == Name).FirstOrDefault();
            int id = 0;
            if (ft == null)
            {
                int i = 1;
                while (i > 0)
                {
                    ft = ii_T2Entities.Football_Teams.Where(x => x.Id == i).FirstOrDefault();
                    if (ft == null)
                    {
                        id = i;
                        i = -1;
                    }
                    i++;
                }
                ft = new Football_Teams();
                ft.Id = id;
                ft.Name = Name;
                ft.Description = Description;
                ft.Players = Players;
                ft.Trophies = Trophies;
                ft.Value = Value;
                ii_T2Entities.Football_Teams.Add(ft);
                ii_T2Entities.SaveChanges();
            }
        }

        [WebMethod]
        public void Delete(String Name)
        {
            Football_Teams ft = ii_T2Entities.Football_Teams.FirstOrDefault(t => t.Name == Name);
            if (ft != null) 
            { 
                ii_T2Entities.Football_Teams.Remove(ft);
                ii_T2Entities.SaveChanges();
            }
            
        }

        [WebMethod]
        public void ModifyDescription(String Name, String Description)
        {
            Football_Teams ft = ii_T2Entities.Football_Teams.Where(x => x.Name == Name).FirstOrDefault();
            if (ft != null)
            {
                ft.Description = Description;
                ii_T2Entities.SaveChanges();
            }
        }

        [WebMethod]
        public void ModifyPlayers(String Name, int Players)
        {
            Football_Teams ft = ii_T2Entities.Football_Teams.Where(x => x.Name == Name).FirstOrDefault();
            if (ft != null)
            {
                ft.Players = Players;
                ii_T2Entities.SaveChanges();
            }
        }

        [WebMethod]
        public void ModifyTrophies(String Name, int Trophies)
        {
            Football_Teams ft = ii_T2Entities.Football_Teams.Where(x => x.Name == Name).FirstOrDefault();
            if (ft != null)
            {
                ft.Trophies = Trophies;
                ii_T2Entities.SaveChanges();
            }
        }

        [WebMethod]
        public void ModifyValue(String Name, long Value)
        {
            Football_Teams ft = ii_T2Entities.Football_Teams.Where(x => x.Name == Name).FirstOrDefault();
            if (ft != null)
            {
                ft.Value = Value;
                ii_T2Entities.SaveChanges();
            }
        }

        [WebMethod]
        public List<String> GetElements()
        {
            List<Football_Teams> list = ii_T2Entities.Football_Teams.ToList();
            List<String> elements = new List<String>();
            foreach (Football_Teams ft in list) {
                elements.Add(ft.Name + "  " + ft.Players.ToString() + "  " + ft.Trophies.ToString() + "  " + 
                    ft.Value.ToString());
                elements.Add(ft.Description);
                elements.Add("");
            }
            elements.RemoveAt(elements.Count - 1);
            return elements;
        }
    }
}
