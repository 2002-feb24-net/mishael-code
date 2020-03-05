namespace Matrix
{
    class Matrix
    {
        private int[] mat;
        private int row;
        private int col;

        public Matrix()
        {
            row = 2;
            col = 2;
            mat = new int[4];
            mat[0] = 0;mat[1] = 0;mat[2] = 0;mat[3] = 0;
        }
        
        public Matrix(int r, int c)
        {
            row = r;
            col = c;
            mat = new int[r*c];
            for (int i=0;i<mat.Length;i++) mat[i] = 0;
        }

        public Matrix(int[][] x)
        {
            row = x[0].Length;
            col = x.Length;
            mat = new int[row*col];
            for(int i=0;i<row;i++) for(int k=0;k<col;k++) set(x[k][i],k,i);
        }

        public Matrix(Matrix x)
        {
            row = x.row;
            col = x.col;
            mat = x.mat;
        }

        public int get(int x,int y) { return mat[y*col+x]; }
        public void set(int set, int x,int y) { mat[y*col+x] = set; }

        public static Matrix addMatrix(Matrix a, Matrix b)
        {
            if(a.row!=b.row||a.row!=b.row) return null;
            Matrix c = new Matrix(a.row,b.col);

            for(int i=0;i<c.mat.Length;i++) c.mat[i] = a.mat[i] + b.mat[i];

            return c;
        }

        public void addMatrix(Matrix b)
        {
            if (row!=b.row||col!=b.col)
            {
                mat = null;
                row = 0;
                col = 0;
            }
            else for(int i=0;i<mat.Length;i++) mat[i]+=b.mat[i];
        }

        public static Matrix subMatrix(Matrix a, Matrix b)
        {
            if(a.row!=b.row||a.row!=b.row) return null;
            Matrix c = new Matrix(a.row,b.col);

            for(int i=0;i<c.mat.Length;i++) c.mat[i] = a.mat[i] - b.mat[i];

            return c;
        }

        public void subMatrix(Matrix b)
        {
            if (row!=b.row||col!=b.col)
            {
                mat = null;
                row = 0;
                col = 0;
            }
            else for(int i=0;i<mat.Length;i++) mat[i]-=b.mat[i];
        }

        public void multiply(Matrix b)
        {
            if(col!=b.row) setTo(new Matrix(0,0));
            else
            {
                Matrix final = new Matrix(row,b.col);
                int[] products = new int[col];
                for (int x=0;x<final.col;x++) for(int y=0;y<final.row;y++)
                {
                    for (int i=0;i<products.Length;i++) products[i] = get(i,y) * b.get(x,i);
                    int sum = 0;
                    for (int i=0;i<products.Length;i++) sum+=products[i];
                    final.set(sum,x,y);
                }
                setTo(final);
            }
        }

        public static Matrix multiply(Matrix a, Matrix b)
        {
            Matrix final = new Matrix(a);
            final.multiply(b);
            return final;
        }

        public void transpose()
        {
            Matrix final = new Matrix(col,row);
            for (int x=0;x<col;x++) for(int y=0;y<row;y++) final.set(get(x,y),y,x);
            setTo(final);
        }

        public static Matrix transpose(Matrix x)
        {
            Matrix y = new Matrix(x);
            y.transpose();
            return y;
        }

        public void negate() { for (int i=0;i<mat.Length;i++) mat[i] *= -1; }

        public static Matrix negate(Matrix x)
        {
            Matrix y = new Matrix(x);
            x.negate();
            return x;
        }

        public void setTo(Matrix x)
        {
            row = x.row;
            col = x.col;
            mat = x.mat;
        }

        public override string ToString()
        {
            string output = "";
            for (int y=0;y<row;y++)
            {
                output += "| ";
                for(int x=0;x<col;x++) output+=get(x,y)+" ";
                output += "|\n";
            }
            return output;
        }
    }
}