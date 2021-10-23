using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoRPN
{
    class Parser : Token
    {
        Stack<BinaryTreeNode> nodeStack = new Stack<BinaryTreeNode>(1000);
        Stack<BinaryTreeNode> operatorStack = new Stack<BinaryTreeNode>(1000);
        public string[] StrOpS = new string[10000];         //Chứa các phần tử trong mảng OpS được ghép thành 1 string sau khi duyệt xong 1 token
        public string[] StrNodeS = new string[10000];       //Chứa các phần tử trong mảng NodeS được ghép thành 1 string sau khi duyệt xong 1 token
        public string[] OpS = new string[10000];            //Lưu các phần tử trong Stack Operator sau khi duyệt xong 1 token
        public string[] NodeS = new string[10000];          //Lưu các phần tử trong Stack Node sau khi duyệt xong 1 token
        public string[] token = new string[10000];
        public int o = 0;       //thứ tự phần tử trong mảng OpS
        public int n = 0;       //thứ tự phần tử trong mảng NodeS
        public int stro = 0;    //thứ tự phần tử trong mảng StrOpS
        public int strn = 0;    //thứ tự phần tử trong mảng StrNodeS

        public string PRN;
        public double KQ;
        string _input;
        public Parser(string input)
        {
            this._input = input;
        }

        //Method thêm phần tử vào trong Mảng
        public void addArr(string[] Str, string k, int i)
        {
            Str[i] = k;
        }
        //Method Chuyển Mảng thành chuỗi và lưu vào trong mảng tương ứng
        public void StackToStr(string[] StrStack, string[] Str, int i, int j)
        {
            int dem = 0;
            string str = "";
            while (dem < i)
            {
                str = str + " " + Str[dem];
                dem++;
            }
            if (str != "")
                StrStack[j] = str;
            else StrStack[j] = "{Empty}";
        }
        //Nếu sau mỗi lần duyệt token mà số phần tử trong mảng nhiều hơn số phần tử trong
        //Stack ta tiến hành xóa bớt phần tử cuối cùng của mảng cho đến khi bằng với Stack
        public void deArrO(string[] Str, Stack<BinaryTreeNode> S)       //Xóa của mảng OpS
        {
            while (o > S.Count)
                o--;
        }
        public void deArrN(string[] Str, Stack<BinaryTreeNode> S)       //Xóa của mảng NodeS
        {
            while (n > S.Count)
                n--;
        }
        void CreateSubTree(Stack<BinaryTreeNode> OperatorStack, Stack<BinaryTreeNode> NodeStack)
        {
            BinaryTreeNode node = OperatorStack.Pop();
            if (IsFunc(node.Value) == false)
                node.RightChild = NodeStack.Pop();
            node.LeftChild = NodeStack.Pop();
            deArrN(NodeS, NodeStack);       //Do trước đó phần tử trong NodeStack được Pop nên tiến hành xóa phần tử trong NodeS
            NodeStack.Push(node);
            addArr(NodeS, node.Value, n); n++; //NodeStack được Push nên tiến hành thêm
        }
        public BinaryTreeNode InfixToExpessionTree()
        {
            _input = AddWhiteSpace(_input);
            token = _input.Split(' ');
            for (int i = 0; i < token.Count(); i++)
            {
                string k = token[i];
                if (IsNumber(k))
                {
                    nodeStack.Push(new BinaryTreeNode(k));
                    addArr(NodeS, k, n); n++;       //Do có push nên ta gọi method thêm, sau đó tăng số thứ tự n lên.
                }
                else if (IsFunc(k))
                {
                    operatorStack.Push(new BinaryTreeNode(k));
                    addArr(OpS, k, o); o++;         //Tương tự
                }
                else if (k == "(")
                {
                    operatorStack.Push(new BinaryTreeNode(k));
                    addArr(OpS, k, o); o++;         //Tương tự
                }
                else if (k == ")")
                {
                    while (operatorStack.Peek().Value != "(")
                        CreateSubTree(operatorStack, nodeStack);
                    operatorStack.Pop();
                    deArrO(OpS, operatorStack);    //Do sau khi CreateSubTree sẽ làm thay đổi số lượng phần tử trong OpStack 
                }
                else if (IsOperator(k))
                {
                    if ((i == 0) || (i > 0 && token[i - 1] == "("))
                    {
                        if (!IsNumber(token[i + 1]))
                        {
                            if (k == "-")
                            {
                                operatorStack.Push(new BinaryTreeNode("minus"));
                                addArr(OpS, k, o); o++;//Tương tự
                            }
                            else if (k == "+")
                            {
                                operatorStack.Push(new BinaryTreeNode("plus"));
                                addArr(OpS, k, o); o++;//Tương tự
                            }
                        }
                        else if (IsNumber(token[i + 1]))
                        {
                            nodeStack.Push(new BinaryTreeNode(token[i] + token[i + 1]));
                            addArr(NodeS, token[i] + token[i + 1], n); n++; //Tương tự
                            i++;
                        }
                    }
                    else
                    {
                        while (operatorStack.Count > 0 && GetPriority(operatorStack.Peek().Value) >= GetPriority(k))
                            CreateSubTree(operatorStack, nodeStack);

                        deArrO(OpS, operatorStack);     //Do sau khi CreateSubTree sẽ làm thay đổi số lượng phần tử trong OpStack
                        operatorStack.Push(new BinaryTreeNode(k));
                        addArr(OpS, k, o); o++;         //Tương tự
                    }
                }
                //Cuối mỗi lần lặp for ta tiến tiến hợp các phần tử của mảng OpS/NodeS thành chuỗi 
                //và lưu vào mảng tương ứng để có thể hiện thị thông tin của các Stack.
                StackToStr(StrOpS, OpS, o, stro); stro++;
                StackToStr(StrNodeS, NodeS, n, strn); strn++;
            }
            while (operatorStack.Count > 0)
            {
                CreateSubTree(operatorStack, nodeStack);
                //Do có CrateSubTree nên ta tiến hành tương tự như các TH đã có ở phía trên
                deArrO(OpS, operatorStack);
                StackToStr(StrOpS, OpS, o, stro); stro++;
                StackToStr(StrNodeS, NodeS, n, strn); strn++;
            }
            return nodeStack.Peek();
        }
        public double LRN(BinaryTreeNode node)
        {
            KQ = 0;
            if (BinaryTreeNode.IsLeaf(node))
            {
                PRN = PRN + node.Value + " ";
                KQ = double.Parse(node.Value);
            }
            else
            {
                double x = LRN(node.LeftChild);
                if (IsFunc(node.Value) == true)
                {
                    if (node.Value != "minus" && node.Value != "plus")
                        PRN = PRN + node.Value + " ";
                    else if (node.Value == "minus") PRN = PRN + "- ";
                    else PRN = PRN + "+ ";
                    switch (node.Value)
                    {
                        case "sqrt": KQ = Math.Sqrt(x); break;
                        case "minus": KQ = -x; break;
                        case "plus": KQ = x; break;
                        case "sin": KQ = Math.Sin(x); break;
                        case "cos": KQ = Math.Cos(x); break;
                        case "tan": KQ = Math.Tan(x); break;
                        case "cotan": KQ = 1 / Math.Tan(x); break;
                    }
                }
                else
                {
                    double y = LRN(node.RightChild);
                    PRN = PRN + node.Value + " ";
                    switch (node.Value)
                    {
                        case "+": KQ = x + y; break;
                        case "-": KQ = x - y; break;
                        case "*": KQ = x * y; break;
                        case "/": KQ = x / y; break;
                        case "^": KQ = Math.Pow(x, y); break;
                    }
                }
            }
            return KQ;
        }
    }
}