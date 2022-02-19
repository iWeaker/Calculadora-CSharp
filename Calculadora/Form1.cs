namespace Calculadora
{
    public  partial class Form1 : Form
    {
        private float? firstValue, secondValue;
        private char? calcType;
        private bool? decimalType = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void setNum(object sender, EventArgs args)
        {
            float val;
             
            Button btn = (Button)sender;
            if (float.TryParse(btn.Text, out val))
            {
                
                if (calcType == null)
                {
                   
                  firstValue = addValues(val, firstValue); 
                }
                else
                {
                   secondValue =addValues(val, secondValue);
                }
            }
        }
        private  float? addValues(float value, float? theValue)
        {

            float? t = theValue; 
            if (t == null)
            {
               if(decimalType == false)
                 t = value;
               else
                 t = value / 10; 
            }
            else
            {
                
                if (decimalType == false)
                {
                    t *= 10;
                    t += value;
                }
               else
                {
                    t += value / 10; 
                }
            }
            textBox1.Text = t.ToString();
            decimalType = false; 
            return t; 

        }
        private void typeFunction(object sender, EventArgs args)
        {
            if (firstValue != null && calcType != null)
            {
                secondValue = null; 
            }
            Button btn = (Button )(sender);
            if (firstValue != null)
            {
                switch (btn.Text)
                {
                    case "+":
                        calcType = '+';
                        break;
                    case "-":
                        calcType = '-';
                        break;
                    case "*":
                        calcType = '*';
                        break;
                    case "/":
                        calcType = '/';
                        break; 
                }
            }
        }


        private void clearFunction(object o, EventArgs args)
        {
            firstValue = secondValue = calcType = null;
            decimalType = false; 
            textBox1.Text = ""; 
        }

        private void decimalFunction(object o, EventArgs args)
        {
            if(decimalType == false)
            {
                decimalType = true;
                if (firstValue == null)
                    textBox1.Text = "0.";
                else
                    textBox1.Text += "."; 
            }    
        }

        private void totalFunction(object o, EventArgs args)
        {
            float? total = 0; 
            if (firstValue != null && secondValue != null && calcType != null)
            {
                switch (calcType)
                {
                    case '+':
                        total = (firstValue + secondValue);
                        textBox1.Text = total.ToString();
                        break;
                    case '-':
                        total = (firstValue - secondValue);
                        textBox1.Text = total.ToString();  
                        break;
                    case '*':
                        total = firstValue * secondValue;
                        textBox1.Text = total.ToString();
                        break;
                    case '/': 
                        total = firstValue / secondValue;
                        textBox1.Text = total.ToString();
                        break; 

                }
                firstValue = total; 

            }
        }
    }
}