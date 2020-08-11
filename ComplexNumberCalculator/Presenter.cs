using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ComplexNumberCalculator
{
    class Presenter
    {
        //ComplexNumber complex;
        MainWindow mainWindow;
        ComplexNumber compl1, compl2, complResult;


        public Presenter(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
          //  this.complex = new ComplexNumber();
            this.mainWindow.AddEvent += MainWindow_AddEvent;
            this.mainWindow.SubEvent += MainWindow_SubEvent;
            this.mainWindow.MulEvent += MainWindow_MulEvent;
            this.mainWindow.DivEvent += MainWindow_DivEvent;
            this.mainWindow.ClrEvent += MainWindow_ClrEvent;
            this.mainWindow.CopyEvent += MainWindow_CopyEvent;

        }

        private void MainWindow_CopyEvent(object sender, EventArgs e)
        {
            if (complResult != null)
            {
                Clipboard.Clear();
                Clipboard.SetText(complResult.ToString());
            }
        }

        private void MainWindow_ClrEvent(object sender, EventArgs e)
        {
            mainWindow.tbOper1Real.Text = "";
            mainWindow.tbOper1Imag.Text = "";
            mainWindow.tbOper2Real.Text = "";
            mainWindow.tbOper2Imag.Text = "";
            mainWindow.tbResultReal.Text = "";
            mainWindow.tbResultImag.Text = "";
        }

        private void MainWindow_DivEvent(object sender, EventArgs e)
        {
            getNumbers();

            complResult = compl1 / compl2;

            setResult();
        }

        private void MainWindow_MulEvent(object sender, EventArgs e)
        {
            getNumbers();

            complResult = compl1 * compl2;

            setResult();
        }

        private void MainWindow_SubEvent(object sender, EventArgs e)
        {
            getNumbers();

            complResult = compl1 / compl2;

            setResult();
        }

        private void MainWindow_AddEvent(object sender, EventArgs e)
        {
            getNumbers();
            
            complResult = compl1 + compl2;
        
            setResult();
        }


       //private void checkField() 
       // {
       // }

        private void getNumbers()
        {

            // TODO: сделать проверку checkField();

            var tmp = new ComplexNumber();

            if(mainWindow.tbOper1Real.Text == "" || Int64.TryParse(mainWindow.tbOper1Imag.Text, out ))
            {
                mainWindow.tbOper1Real.Text = "0";
            }
            
            if (mainWindow.tbOper2Real.Text == "")
            {
                mainWindow.tbOper1Real.Text = "0";
            }

            if (mainWindow.tbOper1Real.Text == "")
            {
                mainWindow.tbOper1Real.Text = "0";
            }

            if (mainWindow.tbOper1Real.Text == "")
            {
                mainWindow.tbOper1Real.Text = "0";
            }


            compl1 = new ComplexNumber(
                Convert.ToInt64(mainWindow.tbOper1Real.Text),
                Convert.ToInt64(mainWindow.tbOper1Imag.Text)); 
            compl2 = new ComplexNumber(
                Convert.ToInt64(mainWindow.tbOper2Real.Text),
                Convert.ToInt64(mainWindow.tbOper2Imag.Text));
        }


        private void setResult()
        {
            mainWindow.tbResultReal.Text = complResult.Real.ToString();
            mainWindow.tbResultImag.Text = complResult.Imag.ToString();
        }
    }
}
