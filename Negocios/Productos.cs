using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Negocios
{
     
     public class Productos
    {
        //Negocios.Propiedades I = new Negocios.Propiedades();


        #region Properties
        // DataTable dt = new DataTable();
        //public int cantIphone{ get; set; }
        
        //public int cantPc { get; set; }


        //public int cantRam { get; set; }
        //public int cantMonitor { get; set; }
        //public int cantteclado { get; set; }
        //public int cantWebcam { get; set; }

        //public int precioIphone { get; set; }
        //public int precioPc { get; set; }
        //public int precioRam { get; set; }
        //public int precioMonitor { get; set; }
        //public int precioteclado { get; set; }
        //public int precioWebcam { get; set; }


        Array MYARRAY = new Array[5];
        #endregion


        public DataTable CrearDT(int cantIphone ,int cantPc ,int cantRam ,int cantMonitor ,
                                 int cantteclado , int cantWebcam)
        {
            //Negocios.Productos obj = new Negocios.Productos();
            DataTable dt = new DataTable();

            dt.Columns.Add("Producto", typeof(string));
            dt.Columns.Add("Cantidad", typeof(int));
            dt.Columns.Add("Precio", typeof(int));

            if (cantIphone > 0)
            {
                DataRow row = dt.NewRow();

                row[0] = "Iphone 14";
                row[1] = cantIphone;
                row[2] = cantIphone * 990; 

                dt.Rows.Add(row);
            }
            
            if (cantPc > 0)
            {
                DataRow row = dt.NewRow();

                row[0] = "PC GAMING";
                row[1] = cantPc;
                row[2] = cantPc * 2000; 

                dt.Rows.Add(row);

            }
            
            if (cantRam > 0)
            {
                DataRow row = dt.NewRow();

                row[0] = "RAM 16GB";
                row[1] = cantRam;
                row[2] =  cantRam * 39;

                dt.Rows.Add(row);

            }

             if (cantMonitor > 0)
             {
                DataRow row = dt.NewRow();

                row[0] = "Monitor LG";
                row[1] = cantMonitor;
                row[2] = cantMonitor * 170;

                dt.Rows.Add(row);

             }

             if (cantteclado > 0)
             {
                DataRow row = dt.NewRow();

                row[0] = "Teclado REDRAGON";
                row[1] = cantteclado;
                row[2] = cantteclado * 39;

                dt.Rows.Add(row);

             }
            if (cantWebcam > 0)
            {
                DataRow row = dt.NewRow();

                row[0] = "Webcam Logitech";
                row[1] = cantWebcam;
                row[2] = cantWebcam * 145;

                dt.Rows.Add(row);

            }


            return dt; 
        }

        public string ObtenerMontoTotal(int cantIphone, int cantPc, int cantRam, int cantMonitor,
                                 int cantteclado, int cantWebcam)
        {
            int TOTAL = 0;

            TOTAL = cantIphone * 990 + cantPc * 2000 + cantRam * 39 +
                    cantMonitor * 170 + cantteclado * 39 + cantWebcam * 145;
       
            return TOTAL.ToString();
        }

     }
}
