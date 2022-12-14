using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_CTDL
{
    internal class Program
    {
        public class HoSo
        {
            public string MaHoSo { get; set; }
            public string Ten { get; set; }
            public string GioiTinh { get; set; }
            public int Luong { get; set; }
            public DateTime NgayLam { get; set; }
        }
        public class Node
        {
            public Node LeftNode { get; set; }
            public Node RightNode { get; set; }
            public HoSo Data { get; set; }
        }
        public class BinarySearchTree
        {
            public Node Root { get; set; }
            public bool Insert(HoSo value)
            {
                Node before = null, after = this.Root;
                while (after != null)
                {
                    before = after;
                    if (value.NgayLam < after.Data.NgayLam)
                        after = after.LeftNode;
                    else if (value.NgayLam > after.Data.NgayLam)
                        after = after.RightNode;
                    else
                        return false;
                }
                Node newNode = new Node();
                newNode.Data = value;
                if (this.Root == null)
                    this.Root = newNode;
                else
                {
                    if (value.NgayLam < before.Data.NgayLam)
                        before.LeftNode = newNode;
                    else
                        before.RightNode = newNode;
                }
                return true;
            }
            public void TraverseInOrder(Node parent)
            {
                CultureInfo viVn = new CultureInfo("vi-VN");
                if (parent != null)
                {
                    TraverseInOrder(parent.LeftNode);
                    Console.Write("{0,5}{1,25}{2,5}{3,15}{4,15}", parent.Data.MaHoSo, parent.Data.Ten, parent.Data.GioiTinh, 
                        parent.Data.Luong, parent.Data.NgayLam.ToString("d",viVn));
                    TraverseInOrder(parent.RightNode);
                }
                Console.WriteLine();
            }

            public Node Find(string value)
            { return this.Find(value, this.Root); }
            private Node Find(string value, Node parent)
            {
                if (parent != null)
                {
                    if (value == parent.Data.Ten) return parent;
                    if (value != parent.Data.Ten)
                        return Find(value, parent.LeftNode);
                    else
                        return Find(value, parent.RightNode);
                }
                return null;
            }
            public void findname(BinarySearchTree tree, Node parent, string ten)
            {
                CultureInfo viVn = new CultureInfo("vi-VN");
                if (tree.Find(ten) != null)
                {
                    Console.Write("{0,5}{1,25}{2,5}{3,15}{4,15}", parent.Data.MaHoSo, parent.Data.Ten, 
                        parent.Data.GioiTinh, parent.Data.Luong, parent.Data.NgayLam.ToString("d", viVn));
                }
                else
                {
                    Console.WriteLine("No information match your search.");
                }
            }
            public Node search(DateTime value1, DateTime value2)
            {
                return this.search(value1, value2, this.Root);
            }
            private Node search(DateTime value1, DateTime value2, Node parent)
            {
                if (parent != null)
                {
                    if (DateTime.Compare(parent.Data.NgayLam, value2) <= 0 &&
                        DateTime.Compare(parent.Data.NgayLam, value1) >= 0) return parent;
                    if (DateTime.Compare(parent.Data.NgayLam, value2) >= 0 &&
                        DateTime.Compare(parent.Data.NgayLam, value1) <= 0)
                        return search(value1, value2, parent.LeftNode);
                    else
                        return search(value1, value2, parent.RightNode);
                }
                return null;
            }
            public void finddate(BinarySearchTree tree, Node parent, DateTime date1, DateTime date2)
            {
                CultureInfo viVn = new CultureInfo("vi-VN");
                if (tree.search(date1, date2) != null)
                {
                    Console.Write("{0,5}{1,25}{2,5}{3,15}{4,15}", parent.Data.MaHoSo, parent.Data.Ten,
                        parent.Data.GioiTinh, parent.Data.Luong, parent.Data.NgayLam.ToString("d", viVn));
                }
                else
                {
                    Console.WriteLine("No information match your search.");
                }
            }
            public void TaoHoSo(ref BinarySearchTree binaryTree)
            {
                HoSo h = new HoSo();
                Console.WriteLine("Nhap Ma ho so: ");
                h.MaHoSo = Console.ReadLine();
                Console.WriteLine("Nhap Ho va ten: ");
                h.Ten = Console.ReadLine();
                Console.WriteLine("Nhap Gioi tinh: ");
                h.GioiTinh = Console.ReadLine();
                Console.WriteLine("Nhap Luong: ");
                h.Luong = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap Ngay lam: ");
                h.NgayLam = DateTime.Parse(Console.ReadLine());
                binaryTree.Insert(h);
            }
        }
        static void Main()
        {
            Console.Clear();

            BinarySearchTree binaryTree = new BinarySearchTree();
            Console.WriteLine("Nhap so luong ho so can them:");
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                binaryTree.TaoHoSo(ref binaryTree);
            }

            Console.WriteLine("Danh sach cac ho so:");
            binaryTree.TraverseInOrder(binaryTree.Root);

            Console.WriteLine("nhap ten can tim kiem: ");
            string name = Console.ReadLine();
            binaryTree.findname(binaryTree, binaryTree.Root, name);

            Console.WriteLine();
            Console.WriteLine("nhap khoang thoi gian can tim kiem");
            DateTime date1 = DateTime.Parse(Console.ReadLine());
            DateTime date2 = DateTime.Parse(Console.ReadLine());
            binaryTree.finddate(binaryTree, binaryTree.Root, date1, date2);
            Console.ReadLine();
        }
    }
}
