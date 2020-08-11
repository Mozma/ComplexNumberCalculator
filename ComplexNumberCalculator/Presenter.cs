using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        }

        private void MainWindow_MulEvent(object sender, EventArgs e)
        {
            getNumbers();

            complResult = compl1 * compl2;

            mainWindow.tbResultReal.Text = complResult.Real.ToString();
            mainWindow.tbResultImag.Text = complResult.Imag.ToString();
        }

        private void MainWindow_SubEvent(object sender, EventArgs e)
        {
            getNumbers();

            complResult = compl1 / compl2;

            mainWindow.tbResultReal.Text = complResult.Real.ToString();
            mainWindow.tbResultImag.Text = complResult.Imag.ToString();
        }

        private void MainWindow_AddEvent(object sender, EventArgs e)
        {
            getNumbers();
            
            complResult = compl1 + compl2;
            
            mainWindow.tbResultReal.Text = complResult.Real.ToString();
            mainWindow.tbResultImag.Text = complResult.Imag.ToString();
        }


       //private void checkField() 
       // {
       // }

        private void getNumbers()
        {

            // TODO: сделать проверку checkField();

            compl1 = new ComplexNumber(
                Convert.ToInt64(mainWindow.tbOper1Real.Text),
                Convert.ToInt64(mainWindow.tbOper1Imag.Text));
            compl2 = new ComplexNumber(
                Convert.ToInt64(mainWindow.tbOper2Real.Text),
                Convert.ToInt64(mainWindow.tbOper2Imag.Text));
        }
    }
}
