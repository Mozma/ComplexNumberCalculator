namespace ComplexNumberCalculator
{
    struct ComplexNumber 
    {
        private decimal real;
        private decimal imag;

        public decimal Real { get { return real; } }
        public decimal Imag { get { return imag; } }
        public ComplexNumber(decimal real, decimal imag)
        {
            this.real = real;
            this.imag = imag;
        }

        #region Operations
        
        #region Logic
        public static bool operator ==(ComplexNumber numb1, ComplexNumber numb2)
        {
            return (numb1.real == numb2.real) && (numb1.imag == numb2.imag); 
        }
        public static bool operator !=(ComplexNumber numb1, ComplexNumber numb2)
        {
            return (numb1.real != numb2.real) || (numb1.imag != numb2.imag);
        }
        #endregion

        #region Math
        public static ComplexNumber operator +(ComplexNumber numb1, ComplexNumber numb2)
        {
            return new ComplexNumber(numb1.real + numb2.real, numb1.imag + numb2.imag);
        }

        public static ComplexNumber operator -(ComplexNumber numb1, ComplexNumber numb2)
        {
            return new ComplexNumber(numb1.real - numb2.real, numb1.imag - numb2.imag);
        }

        public static ComplexNumber operator *(ComplexNumber numb1, ComplexNumber numb2)
        {
            // (ac - bd) + i(ad + bc)
            var result = new ComplexNumber(
                numb1.real * numb2.real - numb1.imag * numb2.imag, 
                numb1.real * numb2.imag + numb1.imag * numb2.real
                );

            return result;
        }

        public static ComplexNumber operator /(ComplexNumber numb1, ComplexNumber numb2)
        {
            return new ComplexNumber(numb1.real - numb2.real, numb1.imag - numb2.imag);
        }

        #endregion

        #endregion

        #region Functions

        public override string ToString()
        {
            if(imag < 0)
            {
                return $"{real}{imag}i";
            }
            else
            {
                return $"{real}+{imag}i";
            }
        }

        #endregion
    }
}
