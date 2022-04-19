using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj2
{
    public class car 
    {
        private string type;
        private int wheels;
        
        public car (string type, int wheels)
        {
            this.type = type;
            this.wheels = wheels;
        }
        public car()
        {

        }
        
        public int Wheels
        {
            get { return wheels; }

            set {this.wheels = value;}
        }
        public string Type
        {
            get { return type; }

            set { this.type = value; }
        }
    }

    public class user
    {
        public string name;
        public string password;
        public user(string name, string password)
        {
            this.name = name;
            this.password = password;
        }
        public user()
        {

        }

        public string Name
        {
            get { return name; }

            set { this.name = value; }
        }
        public string Password
        {
            get { return password; }

            set { this.password = value; }
        }

    }



    //public class car:transoprt
    //{
    //    private string model;
    //    private int speed;
    //    public car(string model, int speed, int wheels, string type) : base(wheels, type)
    //    {
    //        this.model = model;
    //        this.speed = speed;
    //        this.Type=type;
    //        this.Wheels=wheels;
    //    }
    //    public string Model
    //    {
    //        get { return model; }
    //        set { this.model = value; }
    //    }
    //    public int Speed
    //    {
    //        get { return speed; }
    //        set { this.speed = value; }
    //    }



    //}



}
