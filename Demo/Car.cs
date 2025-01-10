using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Car
    {
		#region Attribut
		private int id;
		private string model;
		private double speed;
		#endregion

		#region constructor

		public Car(int id, string model,double speed)
		{
			this.id = id;
			this.model = model;
			this.speed = speed;
		}

		public Car(int id ,string model):this(id,model,250)
		{
   //         this.id = id;
   //         this.model = model;
			//speed = 250;
        }

        public Car(int id):this(id,"BMW",250)
        {
   //         this.id = id;
			//model = "Bmw";
			//speed = 250; ;

        }
        #endregion

        #region Propties
        public int Id
		{
			get { return id; }
			set { id = value; }
		}
		public string Model
		{
			get { return model; }
			set { model = value; }
		}
		public double Spped
		{
			get { return speed; }
			set { speed = value; }
		}
        #endregion

        #region MyRegion

        public override string ToString()
        {
			return $"car Id :{id}\ncar Model: {model}\ncar speed : {speed}";
        }
        #endregion

    }
}
