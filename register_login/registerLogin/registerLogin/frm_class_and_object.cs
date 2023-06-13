using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace registerLogin
{
    public partial class frm_class_and_object : Form
    {
        public frm_class_and_object()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            //obj
            animal_class animal_sound = new animal_class();
            //animal_sound.cat_setter(textBox1.Text);
            //MessageBox.Show(animal_sound.cat_getter());

            //animal_sound.Dog = "Wote wote wote";
            //MessageBox.Show(animal_sound.Dog);

            animal_sound.Cow = "moooo";
            MessageBox.Show(animal_sound.Cow);

            //animal_sound.dog_setter("wote wote");
            //MessageBox.Show(animal_sound.dog_getter());

            //animal_sound.cow_setter("moooooo");
            //MessageBox.Show(animal_sound.cow_getter());

            animal_class bird_sound = new animal_class("kyali kyali");
            animal_class animal_info = new animal_class("Mo Mo", 60, "____", "1963/12/1","Bahan-kyauk tine");
            
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }

    //user create class
    
}
