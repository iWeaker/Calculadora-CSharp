

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
                    t += value / (int)Math.Pow(10, getDecimalCount((float)t) + 1);
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
                    t += value / (int)Math.Pow(10, (getDecimalCount((float)t)) + 1)  ; 
                }
            }
            textBox1.Text = t.ToString();
            return t; 

        }
        private void typeFunction(object sender, EventArgs args)
        {
            decimalType = false;
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
        public int GetDecimalPart(float number)
        {
            var decimalNumber = Convert.ToDecimal(number);
            int decimalPart = int.Parse((decimalNumber % 1).ToString().Replace("0.", ""));

            return decimalPart;
        }
        private void backFunction(object o, EventArgs args)
        {
            if (calcType == null)
            {
                if(firstValue != null)
                {
                    char[] c = firstValue.ToString().ToCharArray();
                    if (c.Length == 1) { 
                        clearFunction(o, args);
                    }else if (c.Length > 1)
                    {
                        firstValue.ToString().Remove(0, 1);
                        textBox1.Text = firstValue.ToString() + "Hola mundo";
                        

                    }
                    else
                    {
                        textBox1.Text = "Llego al else"; 
                    }
                }
            }
            else
            {
                if(secondValue != null)
                {

                }
            }
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

        private static int getDecimalCount(float value)
        {
            bool start = false;
            int count = 0;
            foreach (var s in value.ToString())
            {
                if (s == '.')
                {
                    start = true;
                }
                else if (start)
                {
                    count++;
                }
            }

            return count;
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