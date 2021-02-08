using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class DALClass
    {
        private MusicShopModel Mus = new MusicShopModel();
        public List<Plate> GetPlates()
        {
            return Mus.Plates.ToList();
        }
    }
}

