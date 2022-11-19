using System.Diagnostics;

namespace Assignment11
{
    public partial class Form1 : Form
    {

        private class Animal
        {
            private String name;
            private String type;
            private int age;

            public Animal(string name, string type, int age)
            {
                this.name = name;
                this.type = type;
                this.age = age;
            }

            public override string ToString() {
                return String.Format("New animal parameters: Name: {0}, type: {1}, age: {2}", this.name, this.type, this.age);
            }


        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String animalName = textBox1.Text;
            String animalType = textBox3.Text;
            int animalAge = checkedAgeInput(textBox2.Text);

            Animal newAnimal = new Animal(animalName, animalType, animalAge);

            textBox4.AppendText(newAnimal.ToString());
            textBox4.AppendText(Environment.NewLine);    

        }

        private int checkedAgeInput(String age)
        {
            int ageValue = 0;
            if(Int32.TryParse(age, out int value))
            {
                ageValue = value;
                return ageValue;
            }
            else
            {
                return 0;
            }
        }
    }
}