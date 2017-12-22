using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Text.RegularExpressions;
using WindowsFormsApplication1.entity;

namespace WindowsFormsApplication1.controller
{
    public class dondathangcontroller 
    {
        public IRepository<dondathang> ddhrp;
        Dictionary<string, string> validatedictionary = new Dictionary<string, string>();

        public dondathangcontroller()
        {
            ddhrp = new GenericRepository<dondathang>();
        }
        /*
        public bool validate(dondathang entity)
        {
            return true;
        }
        */

        public int getcurrentid()
        {
            try { return ddhrp.GetQuery().Max(c => c.madondathang); }
            catch { return 0; }
       } 

        public bool add(dondathang entity)
        {
            //if(validate(entity))
                return ddhrp.Add(entity);
            //return false;
        }
        /*
        public bool update(dondathang entity)
        {
            //if(validate(entity))
            return ddhrp.Attach(entity);
            //return false;
        }
        public bool delete(dondathang entity)
        {
            return ddhrp.Delete(entity);
        }
         */
    }
}
