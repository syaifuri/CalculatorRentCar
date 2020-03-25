using Libraries.DataHelpers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrariesTest
{
   public class AttributesObject
    {
        private int varInput0;
        private int varInput01;
        private int varInput02;
        private int varIntOutput;
        private decimal varOutput;
        private decimal varExpected;
        private IEnumerable<CarsModel> carModels;

        

        public int VarInput0
        {
            get { return varInput0; }
            set { varInput0 = value; }
        }
        public int VarInput01
        {
            get { return varInput01; }
            set { varInput01 = value; }
        }
        public int VarInput02
        {
            get { return varInput02; }
            set { varInput02 = value; }
        }

        public int VarIntOutput
        {
            get { return varIntOutput; }
            set { varIntOutput = value; }
        }
        public decimal VarOutput
        {
            get { return varOutput; }
            set { varOutput = value; }
        }

        public decimal VarExpected
        {
            get { return varExpected; }
            set { varExpected = value; }
        }

        public IEnumerable<CarsModel> CarModels
        {
            get { return carModels; }
            set { carModels = value; }
        }
    }
}
