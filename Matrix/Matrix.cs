using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Matrix
    {
        private uint n;
        private double[,] mat;

        public uint N { get { return n; } set { n = value; } }
        public double[,] Mat { get { return mat; } set { mat = value; } }

        public Matrix(double[,] matrix, uint size)
        {
            n = size;
            mat = new double[n, n];
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    mat[i, j] = matrix[i, j];       
                }
            }
        }

        public Matrix(string matrix, uint size)
        {
            n = size;
            mat = new double[n, n];
            string allstr = matrix;
            string[] str = allstr.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            if (n == str.Length)
            {
                for (int i = 0; i < n; i++)
                {
                    string[] str1 = str[i].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    if (n == str1.Length)
                    {
                        try
                        {
                            for (int j = 0; j < n; j++)
                            {
                                mat[i, j] = Convert.ToDouble(str1[j].Trim());
                            }
                        }
                        catch
                        {
                            throw new Exception("Неверные данные");
                        }
                    }
                    else
                    {
                        throw new Exception("Количество столбцов не соответствует введенным данным");
                    }
                }
            }
            else
            {
                throw new Exception("Количество строк не соответствует введенным данным");
            }
        }

        //Транспонирование матрицы
        public double[,] Transpon()
        {
            double tmp;
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < i; j++)
                {
                    tmp = mat[i, j];
                    mat[i, j] = mat[j, i];
                    mat[j, i] = tmp;
                }
            }
            return mat;
        }

        //Очистка матрицы
        public void Clear()
        {
            n = 0;
            mat = null;
        }

        //Нахождение ранга матрицы
        public double Rang()
        {
            Matrix m = new Matrix(this.mat, this.n);
            if (m.n == 1) return 1;

            double tmp;
            uint i, x, y;
            // выбираем минимум
            uint endi = m.n;
            // цикл по всей главной диагонали
            for (i = 0; i < endi; i++)
            {
                // если элемент на диагонали равен 0, то ищем не нулевой элемент в матрице
                if (m.mat[i,i] == 0)
                {
                    // если все элементы нулевые, прерываем цикл
                    if (!m.Search(0, false, out y, out x, i, i)) break;
                    // меняем i-ую строку с y-ой
                    if (i != y) m.Swaprows(i, y);
                    // меняем i-ый столбец с x-ым
                    if (i != x) m.Swapcolumns(i, x);
                    // таким образом, в m[i][i], теперь ненулевой элемент.
                }

                // выносим элемент m[i][i]
                tmp = m.mat[i,i];
                for (x = i; x < m.n; x++)
                {
                    m.mat[i,x] = m.mat[i,x] / tmp;
                }
                // таким образом m[i][i] теперь равен 1
                // зануляем все элементы стоящие под (i, i)-ым и справа от него,
                // при помощи вычитания с опр. коеффициентом
                for (y = i + 1; y < m.n; y++)
                {
                    tmp = m.mat[y,i];
                    for (x = i; x < m.n; x++)
                        m.mat[y,x] -= (m.mat[i,x] * tmp);
                }
                for (x = i + 1; x < m.n; x++)
                {
                    tmp = m.mat[i,x];
                    for (y = i; y < m.n; y++)
                        m.mat[y,x] -= (m.mat[y,i] * tmp);
                }
            }

            // проверяем нулевая ли матрица
            bool f = true;
            for(uint l = 0; l < m.n; l++)
            {
                for(uint k = 0; k < m.n; k++)
                {
                    if (m.mat[l, k] != 0)
                    {
                        f = false;
                        break;
                    }
                }
            }
            if (f)
            {
                return 0;
            }
            else
            {
                // считаем сколько единичек на главной диагонали
                uint cnt = 0;
                for (i = 0; i < endi; i++)
                    if (m.mat[i, i] == 0) break;
                    else cnt++;
                if (cnt == 0) cnt++;
                m = null;
                return cnt;
            }
        }

        // Поиск элемента с указанным значением
        // возвращаеются его координаты если он есть.
        // match - искать равный элемент или отличный от указанного
        // результат функции 0 - не найнен, не 0 - найден
        public bool Search(double what, bool match, out uint uI, out uint uJ, uint starti, uint startj)
        {
            Matrix m = new Matrix(this.mat, this.n);
            if ((starti >= m.n) || (startj >= m.n))
            {
                uI = uJ = 0;
                return false;
            }
            for (uint i = starti; i < m.n; i++)
                for (uint j = startj; j < m.n; j++)
                    if (match == true)
                    {
                        if (m.mat[i,i] == what)
                        {
                            uI = i;
                            uJ = j;
                            return true;
                        }
                    }
                    else
                      if (m.mat[i,j] != what)
                    {
                        uI = i;
                        uJ = j;
                        return true;
                    }
            uI = uJ = 0;
            m = null;
            return false;
        }

        public Matrix Swapcolumns(uint x1, uint x2)
        {
            Matrix m = new Matrix(this.mat, this.n);
            if ((x1 >= m.n) || (x2 >= m.n) || (x1 == x2)) return m;
            double tmp;
            for (uint x = 0; x < m.n; x++)
            {
                tmp = m.mat[x,x1];
                m.mat[x,x1] = m.mat[x,x2];
                m.mat[x,x2] = tmp;
            }
            return m;
        }

        public Matrix Swaprows(uint i1, uint i2)
        {
            Matrix m = new Matrix(this.mat, this.n);
            if ((i1 >= m.n) || (i2 >= m.n) || (i1 == i2)) return m;
            double tmp = m.mat[i1,0];
            m.mat[i1,0] = m.mat[i2,0];
            m.mat[i2,0] = tmp;
            return m;
        }

        //Умножение матрицы на число
        public double[,] Pro_num(double num)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] *= num;
                }
            }
            return mat;
        }

        //Перегрузка операторов
        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            double[,] m = new double[m1.n, m1.n];
            for(int i = 0; i < m.GetLength(0); i++)
            {
                for(int j = 0; j < m.GetLength(0); j++)
                {
                    m[i, j] = m1.mat[i, j] + m2.mat[i, j];
                }
            }
            Matrix mr = new Matrix(m, (uint)m.GetLength(0));
            m = null;
            return mr;
        }

        public static Matrix operator -(Matrix m1, Matrix m2)
        {
            double[,] m = new double[m1.n, m1.n];
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(0); j++)
                {
                    m[i, j] = m1.mat[i, j] - m2.mat[i, j];
                }
            }
            Matrix mr = new Matrix(m, (uint)m.GetLength(0));
            m = null;
            return mr;
        }

        public static Matrix operator *(Matrix m1, Matrix m2)
        {
            double[,] m = new double[m1.n, m1.n];
            for (var i = 0; i < m1.n; i++)
            {
                for (var j = 0; j < m2.n; j++)
                {
                    for (var k = 0; k < m1.n; k++)
                    {
                        m[i, j] += m1.mat[i, k] * m2.mat[k, j];
                    }
                }
            }
            Matrix mr = new Matrix(m, (uint)m.GetLength(0));
            m = null;
            return mr;
        }
    }
}
