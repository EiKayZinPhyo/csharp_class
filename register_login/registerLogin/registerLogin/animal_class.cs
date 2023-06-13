using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace registerLogin
{
    public class animal_class
    {

        public animal_class() {
            MessageBox.Show("default constructor");//default constructor
        }

        public animal_class(string bird)
        {
            MessageBox.Show(bird);     //parameterize constructor
        }

        public animal_class(string name,int age,string nrc,string dob,string address)
        {
            MessageBox.Show($"{name}{age}{nrc}{dob}{address}");
        }


        //class block
        //class member
        string cat = "Meow";
        string dog = "wote";
        string cow = "moo";

        public string cat_getter()
        {
            return cat;
        }

        public void cat_setter(string sound)
        {
            cat = sound;
        }

        public string Dog
        {
            get { return dog; }
            set { dog = value; }
        }

        public string Cow
        {
            get { return cow; }
            set { cow = value; }
        }

        //public string dog_getter()
        //{
        //    return dog;
        //}

        //public void dog_setter(string dog_sound)
        //{
        //    dog = dog_sound;
        //}

        //public string cow_getter()
        //{
        //    return cow;
        //}

        //public void cow_setter(string cow_sound)
        //{
        //    cow = cow_sound;
        //}
    }
}
