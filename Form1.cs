using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlyhoso
{
    public partial class Form1 : Form
    {
        BinarySearchTree binaryTree ;
        DataTable dataTable;
        public Form1()
        {
            InitializeComponent();
            binaryTree = new BinarySearchTree();
            dataTable = new DataTable();
            dataTable.Columns.Add("Mã hồ sơ");
            dataTable.Columns.Add("Họ và tên");
            dataTable.Columns.Add("Giới tính");
            dataTable.Columns.Add("Lương");
            dataTable.Columns.Add("Ngày làm");
        }
        public bool CheckControl()
        {
            if (string.IsNullOrWhiteSpace(txtMahs.Text))
            {
                MessageBox.Show("Bạn chưa nhập Mã hồ sơ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMahs.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtHoten.Text))
            {
                MessageBox.Show("Bạn chưa nhập Họ và tên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoten.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtGioitinh.Text))
            {
                MessageBox.Show("Bạn chưa nhập Giới tính.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGioitinh.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtLuong.Text))
            {
                MessageBox.Show("Bạn chưa nhập Lương.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLuong.Focus();
                return false;
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckControl())
            {
                dataTable.Rows.Add(txtMahs.Text, txtHoten.Text, txtGioitinh.Text, txtLuong.Text, dtpNgaylam.Value.ToString("d"));
                dataGridHoso.DataSource = dataTable;
                HoSo hs = new HoSo(txtMahs.Text, txtHoten.Text, txtGioitinh.Text, txtLuong.Text, dtpNgaylam.Value);
                binaryTree.Insert(hs);
                txtMahs.Clear();
                txtHoten.Clear();
                txtGioitinh.Clear();
                txtLuong.Clear();
                dtpNgaylam.Value = DateTime.Now;
            }
        }

        private void btnTimkiemtheotime_Click(object sender, EventArgs e)
        {
            List<HoSo> lsths = new List<HoSo>();
            DateTime A = dtpTimkiemtheomocA.Value;
            DateTime B = dtpTimkiemtheomocB.Value;

            binaryTree.finddatetime(binaryTree.Root, A, B, ref lsths);

            dataGridHoso.DataSource = null;
            dataGridHoso.DataSource = lsths;

            if (lsths.Count == 0)
            {
                MessageBox.Show("Không tìm thấy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridHoso.DataSource = null;
                dataGridHoso.DataSource = dataTable;
            }
        }

        private void btnTimkiemtheoten_Click(object sender, EventArgs e)
        {
            List<HoSo> lsths = new List<HoSo>();
            string value = txtTimkiemtheoten.Text;
            if (!string.IsNullOrWhiteSpace(value))
            {
                binaryTree.findname(binaryTree.Root, value, ref lsths);

                dataGridHoso.DataSource = null;
                dataGridHoso.DataSource = lsths;
            }
            if (string.IsNullOrWhiteSpace(value) || lsths.Count == 0)
            {
                MessageBox.Show("Không tìm thấy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridHoso.DataSource = null;
                dataGridHoso.DataSource = dataTable;
            }
        }
    }

    public class HoSo
    {
        public string MaHoSo { get; set; }
        public string Ten { get; set; }
        public string GioiTinh { get; set; }
        public string Luong { get; set; }
        public DateTime NgayLam { get; set; }
        public HoSo(string maHoSo, string ten, string gioiTinh, string luong, DateTime ngayLam)
        {
            this.MaHoSo = maHoSo;
            this.Ten = ten;
            this.GioiTinh = gioiTinh;
            this.Luong = luong;
            this.NgayLam = ngayLam;
        }
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
                if (value.NgayLam <= after.Data.NgayLam)
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
                if (value.NgayLam <= before.Data.NgayLam)
                    before.LeftNode = newNode;
                else
                    before.RightNode = newNode;
            }
            return true;
        }
        public void findname(Node parent, string ten, ref List<HoSo> lsths)
        {
            if (parent != null)
            {
                findname(parent.LeftNode, ten, ref lsths);
                if (parent.Data.Ten.ToLower().Contains(ten.ToLower()))
                    lsths.Add(parent.Data);
                findname(parent.RightNode, ten, ref lsths);
            }
        }
        public void finddatetime(Node parent, DateTime A, DateTime B, ref List<HoSo> lsths)
        {
            if (parent != null)
            {
                finddatetime(parent.LeftNode, A, B, ref lsths);
                if (parent.Data.NgayLam >= A && parent.Data.NgayLam <= B)
                {
                    lsths.Add(parent.Data);
                }
                finddatetime(parent.RightNode, A, B, ref lsths);
            }
        }
    }
}
