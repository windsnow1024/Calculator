using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private string[] StrNumber = Array.Empty<string>();
        private string[] StrOperator = Array.Empty<string>();
        private double[] DoubleNumber = Array.Empty<double>();
        private double DoubleOutput, DoubleTmp;
        private string Input, IsEnd, IsFinish, Stri, StrIndex, StrInput, StrOutput;
        private int i, ip, count, LP, RP;

        private void Button1(object sender, RoutedEventArgs e)
        {
            InputTextBox.Text = InputTextBox.Text == "0" ? "1" : $"{InputTextBox.Text}1";
        }
        private void Button2(object sender, RoutedEventArgs e)
        {
            InputTextBox.Text = InputTextBox.Text == "0" ? "2" : $"{InputTextBox.Text}2";
        }
        private void Button3(object sender, RoutedEventArgs e)
        {
            InputTextBox.Text = InputTextBox.Text == "0" ? "3" : $"{InputTextBox.Text}3";
        }
        private void Button4(object sender, RoutedEventArgs e)
        {
            InputTextBox.Text = InputTextBox.Text == "0" ? "4" : $"{InputTextBox.Text}4";
        }
        private void Button5(object sender, RoutedEventArgs e)
        {
            InputTextBox.Text = InputTextBox.Text == "0" ? "5" : $"{InputTextBox.Text}5";
        }
        private void Button6(object sender, RoutedEventArgs e)
        {
            InputTextBox.Text = InputTextBox.Text == "0" ? "6" : $"{InputTextBox.Text}6";
        }
        private void Button7(object sender, RoutedEventArgs e)
        {
            InputTextBox.Text = InputTextBox.Text == "0" ? "7" : $"{InputTextBox.Text}7";
        }
        private void Button8(object sender, RoutedEventArgs e)
        {
            InputTextBox.Text = InputTextBox.Text == "0" ? "8" : $"{InputTextBox.Text}8";
        }
        private void Button9(object sender, RoutedEventArgs e)
        {
            InputTextBox.Text = InputTextBox.Text == "0" ? "9" : $"{InputTextBox.Text}9";
        }
        private void Button0(object sender, RoutedEventArgs e)
        {
            InputTextBox.Text = InputTextBox.Text == "0" ? "0" : $"{InputTextBox.Text}0";
        }
        private void ButtonPlus(object sender, RoutedEventArgs e)
        {
            InputTextBox.Text = $"{InputTextBox.Text}+";
        }
        private void ButtonMinus(object sender, RoutedEventArgs e)
        {
            InputTextBox.Text = $"{InputTextBox.Text}-";
        }

        private void ButtonDot(object sender, RoutedEventArgs e)
        {
            InputTextBox.Text = $"{InputTextBox.Text}.";
        }

        private void ButtonMultiply(object sender, RoutedEventArgs e)
        {
            InputTextBox.Text = $"{InputTextBox.Text}×";
        }
        private void ButtonDivide(object sender, RoutedEventArgs e)
        {
            InputTextBox.Text = $"{InputTextBox.Text}÷";
        }

        private void ButtonFactorial(object sender, RoutedEventArgs e)
        {
            InputTextBox.Text = $"{InputTextBox.Text}!";
        }
        private void ButtonRParentheses(object sender, RoutedEventArgs e)
        {
            InputTextBox.Text = $"{InputTextBox.Text})";
        }
        private void ButtonLParentheses(object sender, RoutedEventArgs e)
        {
            InputTextBox.Text = $"{InputTextBox.Text}(";
        }

        private void ButtonE(object sender, RoutedEventArgs e)
        {
            InputTextBox.Text = InputTextBox.Text == "0" ? "e" : $"{InputTextBox.Text}e";
        }
        private void ButtonPi(object sender, RoutedEventArgs e)
        {
            InputTextBox.Text = InputTextBox.Text == "0" ? "π" : $"{InputTextBox.Text}π";
        }
        private void ButtonSquare(object sender, RoutedEventArgs e)
        {
            InputTextBox.Text = $"{InputTextBox.Text}^2";
        }
        private void ButtonSquareroot(object sender, RoutedEventArgs e)
        {
            i = InputTextBox.Text.Length - 1;//i用于表示正在处理第i个字符，从最后一个字符开始处理
            Stri = InputTextBox.Text.Substring(i, 1);//Stri用于记录当前字符
            while (Stri is "0" or "1" or "2" or "3" or "4" or "5" or "6" or "7" or "8" or "9" or ".")//若当前字符为数字或小数点
            {
                if (i > 0)//如果现在不在处理第一个字符
                {
                    i--;//处理上一个字符
                    Stri = InputTextBox.Text.Substring(i, 1);//记录当前字符
                }
                else//如果现在正在处理第一个字符，而还未跳出循环，则表明该段数字前没有符号
                {
                    Stri = "End";//指示停止
                    InputTextBox.Text = $"2√{InputTextBox.Text}";//在数字前加上根号
                }
            }
            if (Stri != "End")
            {
                InputTextBox.Text = $"{InputTextBox.Text.Substring(0, i + 1)}2√{InputTextBox.Text.Substring(i + 1, InputTextBox.Text.Length - i - 1)}";//核心：将根号插入到数字前
            }
        }
        private void ButtonPower(object sender, RoutedEventArgs e)
        {
            InputTextBox.Text = $"{InputTextBox.Text}^";
        }
        private void ButtonPower10(object sender, RoutedEventArgs e)
        {
            InputTextBox.Text = $"10^{InputTextBox.Text}";
        }
        private void ButtonLog10(object sender, RoutedEventArgs e)
        {
            InputTextBox.Text = $"{InputTextBox.Text}log10";
        }
        private void ButtonLn(object sender, RoutedEventArgs e)
        {
            InputTextBox.Text = $"{InputTextBox.Text}ln";
        }

        private void ButtonPlusminus(object sender, RoutedEventArgs e)
        {
            i = InputTextBox.Text.Length - 1;//i用于表示正在处理第i个字符，从最后一个字符开始处理
            Stri = InputTextBox.Text.Substring(i, 1);//Stri用于记录当前字符
            while (Stri is "0" or "1" or "2" or "3" or "4" or "5" or "6" or "7" or "8" or "9" or ".")//若当前字符为数字或小数点
            {
                if (i > 0)//如果现在不在处理第一个字符
                {
                    i--;//处理上一个字符
                    Stri = InputTextBox.Text.Substring(i, 1);//记录当前字符
                }
                else//如果现在正在处理第一个字符，而还未跳出循环，则表明该段数字的正号被省略
                {
                    Stri = "End";//指示停止
                    InputTextBox.Text = "-" + InputTextBox.Text;//在数字前加上减号
                }
            }
            if (Stri != "End")//如果不是该段数字的正号被省略的情况，跳出上个循环表明当前处理字符为符号
            {
                switch (Stri)//核心：判断符号，删除原符号以后的原字符串+新符号+原数字
                {
                    case "-":
                        InputTextBox.Text = InputTextBox.Text.Remove(i) + "+" + InputTextBox.Text.Substring(i + 1, InputTextBox.Text.Length - i - 1);
                        break;
                    case "+":
                        InputTextBox.Text = InputTextBox.Text.Remove(i) + "-" + InputTextBox.Text.Substring(i + 1, InputTextBox.Text.Length - i - 1);
                        break;
                    default:
                        break;
                }
            }
        }

        private void ButtonClear(object sender, RoutedEventArgs e)
        {
            InputTextBox.Text = "";
            OutputTextBox.Text = "";
        }
        private void ButtonBackspace(object sender, RoutedEventArgs e)
        {
            if (InputTextBox.Text.Length > 0)
            {
                InputTextBox.Text = InputTextBox.Text[0..^1];
            }
        }



        private void ButtonEqual(object sender, RoutedEventArgs e)
        {
            //重置变量
            Stri = null;//用于临时指示当前字符
            DoubleTmp = 0;//用于临时计算用途
            i = 0;//用于记录当前正在处理第i个字符
            ip = -1;//用于记录当前正在处理第ip组字符，未被运算符分割的数字成一组，每个运算符各成一组
            count = 0;//用于临时计数器
            Array.Clear(StrNumber, 0, StrNumber.Length);//用于记录数字组
            Array.Clear(StrOperator, 0, StrOperator.Length);//用于记录运算符
            DoubleOutput = 0;//用于计算当前结果
            StrOutput = null;//用于将计算结果替代StrInput中的过程
            StrInput = null;//用于记录当前输入
            IsEnd = null;//用于指示最外层循环何时结束
            IsFinish = null;//用于指示括号检索何时结束
            LP = 0;//用于临时指示左括号位置
            RP = 0;//用于临时指示右括号位置
            StrIndex = null;//用于临时检索括号

            Input = InputTextBox.Text;//Input

            //寻找内层可处理括号
            while (IsEnd != "End")
            {

                //重置变量
                Stri = null;
                i = 0;
                StrInput = null;
                StrOutput = null;
                LP = 0;
                RP = 0;
                Array.Clear(StrNumber, 0, StrNumber.Length);
                Array.Clear(StrOperator, 0, StrOperator.Length);
                IsFinish = null;

                StrIndex = Input;

                //若Input含包含非负号加纯数字的括号，则令StrInput为内层括号中内容，否则令StrInput为Input
                if (StrIndex.Contains("(") == true)
                {
                    while (IsFinish != "Finish")
                    {
                        //重置变量
                        LP = 0;
                        RP = 0;

                        Stri = i < StrIndex.Length ? StrIndex.Substring(i, 1) : "End";//若存在，则检查第i个字符，否则指示当前字符为End
                        //顺序寻找下一个括号
                        if (Stri == "(")
                        {
                            LP = i;
                            i++;//开始处理下一个字符
                            Stri = i < StrIndex.Length ? StrIndex.Substring(i, 1) : "End";

                            //判断括号内是否只包含数字

                            //若括号内第一个字符为负号，处理下一个字符
                            if (Stri == "-")
                            {
                                i++;
                                Stri = i < StrIndex.Length ? StrIndex.Substring(i, 1) : "End";
                            }

                            while (Stri is "0" or "1" or "2" or "3" or "4" or "5" or "6" or "7" or "8" or "9" or "." or "π" or "e")
                            {
                                i++;
                                Stri = i < StrIndex.Length ? StrIndex.Substring(i, 1) : "End";
                            }
                            if (Stri == ")")//是，将括号替代为空格
                            {
                                RP = i;
                                StrIndex = StrIndex.Remove(LP, 1);
                                StrIndex = StrIndex.Insert(LP, " ");
                                StrIndex = StrIndex.Remove(RP, 1);
                                StrIndex = StrIndex.Insert(RP, " ");
                                i = 0;
                                Stri = i < StrIndex.Length ? StrIndex.Substring(i, 1) : "End";
                            }
                            else//不是，寻找下一个")"
                            {
                                while (RP == 0 && Stri != "End")
                                {
                                    if (Stri == ")")//若为同层级括号，令StrInput为内层括号中内容，跳出检索循环
                                    {
                                        RP = i;
                                        StrInput = Input.Substring(LP + 1, RP - LP - 1);
                                        IsFinish = "Finish";
                                    }
                                    i++;
                                    Stri = i < StrIndex.Length ? StrIndex.Substring(i, 1) : "End";
                                    if (StrIndex.Substring(i - 1, 1) == "(")//若不为同层级括号，从内层级左括号开始重新检索
                                    {
                                        Stri = "End";
                                        i--;
                                    }
                                }
                            }

                        }
                        else//当前字符不是"("，前往下一个字符
                        {
                            i++;
                            Stri = i < StrIndex.Length ? Input.Substring(i, 1) : "End";
                            if (i >= StrIndex.Length)//若未找到可处理的括号，跳出检索循环
                            {
                                IsFinish = "Finish";
                            }
                        }
                    }
                    if (StrIndex.Contains("(") == false)//若未找到可处理的括号，令StrInput为Input
                    {
                        StrInput = Input;
                    }
                }
                else StrInput = Input;

                //提取器:

                //重置变量
                Stri = null;
                i = 0;

                while (i < StrInput.Length)
                {

                    //提取数字:

                    //处理最前端的负号
                    if (i == 0)
                    {
                        Stri = i < StrInput.Length ? StrInput.Substring(i, 1) : "End";

                        if (Stri == "-")
                        {
                            StrNumber[0] = "-";//提取器核心
                            i++;
                            Stri = i < StrInput.Length ? StrInput.Substring(i, 1) : "End";
                        }
                    }

                    //处理括号

                    if (Stri == "(")//处理左括号
                    {
                        ip++;//开始处理下一组字符
                        i++;
                        Stri = i < StrInput.Length ? StrInput.Substring(i, 1) : "End";

                        if (Stri == "-")//处理括号内的负号
                        {
                            Array.Resize(ref StrNumber, ip + 1);//增加字符串数字数组长度
                            Array.Resize(ref StrOperator, ip + 1);//增加运算符数组长度
                            Array.Resize(ref DoubleNumber, ip + 1);//增加双精度数字数组长度
                            StrNumber[ip] = StrNumber[ip] + "-";
                            i++;
                            Stri = i < StrInput.Length ? StrInput.Substring(i, 1) : "End";
                        }
                        ip--;//回到上一组字符
                    }

                    if (Stri == ")")//处理右括号
                    {
                        i++;
                        Stri = i < StrInput.Length ? StrInput.Substring(i, 1) : "End";
                    }

                    //若字符为数字/小数点/π/e
                    if (Stri is "0" or "1" or "2" or "3" or "4" or "5" or "6" or "7" or "8" or "9" or "." or "π" or "e")
                    {
                        ip++;//开始处理下一组字符

                        while (Stri is "0" or "1" or "2" or "3" or "4" or "5" or "6" or "7" or "8" or "9" or "." or "π" or "e")//分情况处理 数字/小数点，π，e
                        {
                            Array.Resize(ref StrNumber, ip + 1);
                            Array.Resize(ref StrOperator, ip + 1);
                            Array.Resize(ref DoubleNumber, ip + 1);
                            if (Stri is "0" or "1" or "2" or "3" or "4" or "5" or "6" or "7" or "8" or "9" or ".")//数字/小数点
                            {
                                StrNumber[ip] = StrNumber[ip] + StrInput.Substring(i, 1);//提取器核心
                            }
                            if (Stri is "π")//π
                            {
                                StrNumber[ip] = StrNumber[ip] + Math.PI;//提取器核心
                            }
                            if (Stri is "e")//e
                            {
                                StrNumber[ip] = StrNumber[ip] + Math.E;//提取器核心
                            }
                            i++;
                            Stri = i < StrInput.Length ? StrInput.Substring(i, 1) : "End";
                        }
                    }

                    //提取运算符:

                    //若字符不为括号，则为运算符
                    if (Stri is "!" or "^" or "√" or "×" or "÷" or "+" or "-")
                    {
                        ip++;

                        Array.Resize(ref StrNumber, ip + 1);
                        Array.Resize(ref StrOperator, ip + 1);
                        Array.Resize(ref DoubleNumber, ip + 1);
                        StrOperator[ip] = StrOperator[ip] + StrInput.Substring(i, 1);//提取器核心

                        i++;
                        Stri = i < StrInput.Length ? StrInput.Substring(i, 1) : "End";
                    }

                    if (Stri is "l" or "o" or "g" or "n")
                    {
                        ip++;
                        while (Stri is "l" or "o" or "g" or "n")
                        {
                            Array.Resize(ref StrNumber, ip + 1);
                            Array.Resize(ref StrOperator, ip + 1);
                            Array.Resize(ref DoubleNumber, ip + 1);
                            StrOperator[ip] = StrOperator[ip] + StrInput.Substring(i, 1);//提取器核心
                            i++;
                            Stri = i < StrInput.Length ? StrInput.Substring(i, 1) : "End";
                        }

                    }

                }


                //运算器:

                //阶乘器
                ip = 0;//重新开始处理字符组
                for (int ip = 0; ip < StrNumber.Length; ip++)
                {
                    if (StrOperator[ip] == "!")//寻找运算符
                    {
                        //寻找被运算数
                        count = 1;
                        while (StrNumber[ip - count] == null)
                        {
                            count++;
                        }
                        DoubleNumber[ip - count] = double.Parse(StrNumber[ip - count]);//转换被运算数
                        DoubleTmp = DoubleNumber[ip - count];//记录被运算数
                        Array.Clear(StrNumber, ip - count, 1);//清除被运算数
                        //运算器核心
                        DoubleOutput = 1;
                        i = 0;
                        while (DoubleTmp - i > 0)
                        {
                            DoubleOutput *= (DoubleTmp - i);
                            i++;
                        }
                        StrNumber[ip] = DoubleOutput.ToString();//记录结果到数字的运算符位置
                        StrOperator[ip] = null;//清除StrOperator
                    }
                }

                //乘方器
                ip = 0;//重新开始处理字符组
                for (int ip = 0; ip < StrNumber.Length; ip++)
                {
                    if (StrOperator[ip] == "^")//寻找运算符
                    {
                        //寻找被运算数
                        count = 1;
                        while (StrNumber[ip - count] == null)
                        {
                            count++;
                        }
                        DoubleNumber[ip - count] = double.Parse(StrNumber[ip - count]);//转换被运算数
                        DoubleTmp = DoubleNumber[ip - count];//记录被运算数
                        Array.Clear(StrNumber, ip - count, 1);//清除被运算数
                        //寻找主运算数
                        count = 1;
                        while (StrNumber[ip + count] == null)
                        {
                            count++;
                        }
                        DoubleNumber[ip + count] = double.Parse(StrNumber[ip + count]);//转换主运算数
                        DoubleOutput = Math.Pow(DoubleTmp, DoubleNumber[ip + count]);//运算器核心
                        Array.Clear(StrNumber, ip + count, 1);//清除主运算数
                        StrNumber[ip] = DoubleOutput.ToString();//记录结果到数字的运算符位置
                        StrOperator[ip] = null;//清除StrOperator
                    }
                }

                //开方器
                ip = 0;//重新开始处理字符组
                for (int ip = 0; ip < StrNumber.Length; ip++)
                {
                    if (StrOperator[ip] == "√")//寻找运算符
                    {
                        //寻找被运算数
                        count = 1;
                        while (StrNumber[ip - count] == null)
                        {
                            count++;
                        }
                        DoubleNumber[ip - count] = double.Parse(StrNumber[ip - count]);//转换被运算数
                        DoubleTmp = DoubleNumber[ip - count];//记录被运算数
                        Array.Clear(StrNumber, ip - count, 1);//清除被运算数
                        //寻找主运算数
                        count = 1;
                        while (StrNumber[ip + count] == null)
                        {
                            count++;
                        }
                        DoubleNumber[ip + count] = double.Parse(StrNumber[ip + count]);//转换主运算数
                        DoubleOutput = Math.Pow(DoubleNumber[ip + count], 1 / DoubleTmp);//运算器核心
                        Array.Clear(StrNumber, ip + count, 1);//清除主运算数
                        StrNumber[ip] = DoubleOutput.ToString();//记录结果到数字的运算符位置
                        StrOperator[ip] = null;//清除StrOperator
                    }
                }

                //log器
                ip = 0;//重新开始处理字符组
                for (int ip = 0; ip < StrNumber.Length; ip++)
                {
                    if (StrOperator[ip] == "log")//寻找运算符
                    {
                        //寻找底数
                        count = 1;
                        while (StrNumber[ip + count] == null)
                        {
                            count++;
                        }
                        DoubleNumber[ip + count] = double.Parse(StrNumber[ip + count]);//转换底数
                        DoubleTmp = DoubleNumber[ip + count];//记录底数
                        Array.Clear(StrNumber, ip + count, 1);//清除被运算数
                        //寻找主运算数
                        while (StrNumber[ip + count] == null)
                        {
                            count++;
                        }
                        DoubleNumber[ip + count] = double.Parse(StrNumber[ip + count]);//转换主运算数
                        DoubleOutput = Math.Log(DoubleNumber[ip + count], DoubleTmp);//运算器核心
                        Array.Clear(StrNumber, ip + count, 1);//清除主运算数
                        StrNumber[ip] = DoubleOutput.ToString();//记录结果到数字的运算符位置
                        StrOperator[ip] = null;//清除StrOperator
                    }
                }

                //ln器
                ip = 0;//重新开始处理字符组
                for (int ip = 0; ip < StrNumber.Length; ip++)
                {
                    if (StrOperator[ip] == "ln")//寻找运算符
                    {
                        //寻找主运算数
                        count = 1;
                        while (StrNumber[ip + count] == null)
                        {
                            count++;
                        }
                        DoubleNumber[ip + count] = double.Parse(StrNumber[ip + count]);//转换主运算数
                        DoubleOutput = Math.Log(DoubleNumber[ip + count], Math.E);//运算器核心
                        Array.Clear(StrNumber, ip + count, 1);//清除主运算数
                        StrNumber[ip] = DoubleOutput.ToString();//记录结果到数字的运算符位置
                        StrOperator[ip] = null;//清除StrOperator
                    }
                }


                //乘法器
                ip = 0;//重新开始处理字符组
                for (int ip = 0; ip < StrNumber.Length; ip++)
                {
                    if (StrOperator[ip] == "×")//寻找运算符
                    {
                        //寻找被运算数
                        count = 1;
                        while (StrNumber[ip - count] == null)
                        {
                            count++;
                        }
                        DoubleNumber[ip - count] = double.Parse(StrNumber[ip - count]);//转换被运算数
                        DoubleTmp = DoubleNumber[ip - count];//记录被运算数
                        Array.Clear(StrNumber, ip - count, 1);//清除被运算数
                        //寻找主运算数
                        count = 1;
                        while (StrNumber[ip + count] == null)
                        {
                            count++;
                        }
                        DoubleNumber[ip + count] = double.Parse(StrNumber[ip + count]);//转换主运算数
                        DoubleOutput = DoubleTmp * DoubleNumber[ip + count];//运算器核心
                        Array.Clear(StrNumber, ip + count, 1);//清除主运算数
                        StrNumber[ip] = DoubleOutput.ToString();//记录结果到数字的运算符位置
                        StrOperator[ip] = null;//清除StrOperator
                    }
                }

                //除法器
                ip = 0;//重新开始处理字符组
                for (int ip = 0; ip < StrNumber.Length; ip++)
                {
                    if (StrOperator[ip] == "÷")//寻找运算符
                    {
                        //寻找被运算数
                        count = 1;
                        while (StrNumber[ip - count] == null)
                        {
                            count++;
                        }
                        DoubleNumber[ip - count] = double.Parse(StrNumber[ip - count]);//转换被运算数
                        DoubleTmp = DoubleNumber[ip - count];//记录被运算数
                        Array.Clear(StrNumber, ip - count, 1);//清除被运算数
                        //寻找主运算数
                        count = 1;
                        while (StrNumber[ip + count] == null)
                        {
                            count++;
                        }
                        DoubleNumber[ip + count] = double.Parse(StrNumber[ip + count]);//转换主运算数
                        DoubleOutput = DoubleTmp / DoubleNumber[ip + count];//运算器核心
                        Array.Clear(StrNumber, ip + count, 1);//清除主运算数
                        StrNumber[ip] = DoubleOutput.ToString();//记录结果到数字的运算符位置
                        StrOperator[ip] = null;//清除StrOperator
                    }
                }

                //加法器
                ip = 0;//重新开始处理字符组
                for (int ip = 0; ip < StrNumber.Length; ip++)
                {
                    if (StrOperator[ip] == "+")//寻找运算符
                    {
                        //寻找被运算数
                        count = 1;
                        while (StrNumber[ip - count] == null)
                        {
                            count++;
                        }
                        DoubleNumber[ip - count] = double.Parse(StrNumber[ip - count]);//转换被运算数
                        DoubleTmp = DoubleNumber[ip - count];//记录被运算数
                        Array.Clear(StrNumber, ip - count, 1);//清除被运算数
                        //寻找主运算数
                        count = 1;
                        while (StrNumber[ip + count] == null)
                        {
                            count++;
                        }
                        DoubleNumber[ip + count] = double.Parse(StrNumber[ip + count]);//转换主运算数
                        DoubleOutput = DoubleTmp + DoubleNumber[ip + count];//运算器核心
                        Array.Clear(StrNumber, ip + count, 1);//清除主运算数
                        StrNumber[ip] = DoubleOutput.ToString();//记录结果到数字的运算符位置
                        StrOperator[ip] = null;//清除StrOperator
                    }
                }

                //减法器
                ip = 0;//重新开始处理字符组
                for (int ip = 0; ip < StrNumber.Length; ip++)
                {
                    if (StrOperator[ip] == "-")//寻找运算符
                    {
                        //寻找被运算数
                        count = 1;
                        while (StrNumber[ip - count] == null)
                        {
                            count++;
                        }
                        DoubleNumber[ip - count] = double.Parse(StrNumber[ip - count]);//转换被运算数
                        DoubleTmp = DoubleNumber[ip - count];//记录被运算数
                        Array.Clear(StrNumber, ip - count, 1);//清除被运算数
                        //寻找主运算数
                        count = 1;
                        while (StrNumber[ip + count] == null)
                        {
                            count++;
                        }
                        DoubleNumber[ip + count] = double.Parse(StrNumber[ip + count]);//转换主运算数
                        DoubleOutput = DoubleTmp - DoubleNumber[ip + count];//运算器核心
                        Array.Clear(StrNumber, ip + count, 1);//清除主运算数
                        StrNumber[ip] = DoubleOutput.ToString();//记录结果到数字的运算符位置
                        StrOperator[ip] = null;//清除StrOperator
                    }
                }

                if (DoubleOutput < 0)//若临时计算结果为负数，则加上括号再转换为字符串，否则直接转换为字符串
                {
                    StrOutput = "(" + DoubleOutput.ToString() + ")";
                }
                else StrOutput = DoubleOutput.ToString();

                if (Input.Contains("(" + StrInput + ")") == true)//将临时计算结果字符串替换原过程
                {
                    Input = Input.Replace("(" + StrInput + ")", StrOutput);
                }
                else if (Input.Contains(StrInput) == true)
                {
                    Input = Input.Replace(StrInput, StrOutput);
                    IsEnd = "End";
                }
                else IsEnd = "End";

                if (IsEnd == "PreEnd")//循环结束
                {
                    IsEnd = "End";
                }
                if (Input.Contains("(") == false && IsEnd != "End")//如果下一次处理的过程不含括号，则再循环一次
                {
                    IsEnd = "PreEnd";
                }

            }

            //Output
            OutputTextBox.Text = StrOutput;

        }

    }
}
