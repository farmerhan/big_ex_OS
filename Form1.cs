using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Required namespaces
using System.Management;
using System.Dynamic;
using System.Diagnostics;

namespace ProcessesManangement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // Khởi tạo đối tượng trong WDF
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Vũ
            renderProcessesOnListView();
            // Vũ

            //Huyền
            // Khởi tạo hàm thời gian
            timer.Start();
            //Huyền
        }

        /*
        ==========================================================================================
                                                Phần xử lý của Vũ 
        ==========================================================================================
        */
        /*
         Do đối tượng Process không thể lấy đủ thông tin về các tiến trình,
         vì vậy mà cần xử lý để lấy hai trường username(Người đang chạy tiến trình), và description (Thông tin chi tiết của tiến trình)
         */
        public ExpandoObject GetProcessExtraInformation(int processId)
        {
            // Mã truy vấn lấy mọi thông tin về tiến trình của lớp Win32_Process
            string query = "Select * From Win32_Process Where ProcessID = " + processId;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            ManagementObjectCollection processList = searcher.Get();

            // Tạo một đối tượng động để lưu trữ một vài thuộc tính mới lấy về
            dynamic response = new ExpandoObject();
            response.Description = "";
            response.Username = "Unknown";

            // Lặp lại đối tương ProcessList sau đó sẽ 
            foreach (ManagementObject obj in processList)
            {
                // Lấy thông tin username
                string[] argList = new string[] { string.Empty, string.Empty };
                int returnVal = Convert.ToInt32(obj.InvokeMethod("GetOwner", argList));
                // Giá trị tại vị trí 0 là username
                if (returnVal == 0)
                {
                    // Cho usename vào đối tương response
                    response.Username = argList[0];
                }

                // Lấy thông tin chi tiết của tiến trình nếu tồn tại
                if (obj["ExecutablePath"] != null)
                {
                    try
                    {
                        FileVersionInfo info = FileVersionInfo.GetVersionInfo(obj["ExecutablePath"].ToString());
                        response.Description = info.FileDescription;
                    }
                    catch { }
                }
            }

            // Trả về đối tượng bao gồm hai thuộc tính username và description
            return response;
        }

        /*
            Hàm chuyển đổi giá trị của số byte thực thành đơn vị dễ đọc 
        */
        public string BytesToReadableValue(long number)
        {
            List<string> suffixes = new List<string> { " B", " KB", " MB", " GB", " TB", " PB" };

            for (int i = 0; i < suffixes.Count; i++)
            {
                long temp = number / (int)Math.Pow(1024, i + 1);

                if (temp == 0)
                {
                    return (number / (int)Math.Pow(1024, i)) + suffixes[i];
                }
            }

            return number.ToString();
        }

        // Hàm sẽ lấy mọi thông tin sau đó hiển thị tiến trình lên listview
        Process[] processList;
        public void renderProcessesOnListView()
        {
            // Tạo bảng lưu trữ tiến trình
            processList = Process.GetProcesses();

            // Tạo ảnh bạn sẽ đưa ra cho mọi tiến trình
            ImageList Imagelist = new ImageList();

            // Lặp qua mọi tiến trình để đưa ra những thông tin
            foreach (Process process in processList)
            {
                // Định nghĩa trạng thái của tiến trình
                string status = (process.Responding == true ? "Responding" : "Not responding");

                // Lấy 2 thông tin về username và description mà lớp Process không có
                dynamic extraProcessInfo = GetProcessExtraInformation(process.Id);

                // Tạo mảng cái mà sẽ lưu thông tin được show ra
                string[] row = {
                    // 1 Tên tiến trình
                    process.ProcessName,
                    // 2 ID tiến trình
                    process.Id.ToString(),
                    // 3 Trạng thái tiến trình
                    status,
                    // 4 Tên người dùng người mà đang bật tiến trình
                    extraProcessInfo.Username,
                    // 5 Lượng bộ nhớ sử dụng
                    BytesToReadableValue(process.PrivateMemorySize64),
                    //process.PrivateMemorySize64.ToString(),
                    // 6 Mô tả tiến trình
                    extraProcessInfo.Description
                };

                //
                // Nếu tiến trình không có ảnh, hành động này ngăn chặn ứng dụng bị lỗi
                try
                {
                    // Thêm icon vào ImageList
                    Imagelist.Images.Add(
                        // Thêm một mã định danh cho mỗi icon của tiến trình (Nó giống như ID của tiến trình)
                        process.Id.ToString(),
                        // Thêm icon vào danh sách và chuyển đổi chúng thành Bitmap định dạng hiển thị trong window form
                        // Dữ liệu hình ảnh của biểu tượng có thể được truy xuất bằng ***Icon.ExtractAssociatedIcon***
                        Icon.ExtractAssociatedIcon(process.MainModule.FileName).ToBitmap()
                    );
                }
                catch { }

                // Tạo một Mục mới để thêm vào chế độ xem danh sách mà yêu cầu hàng thông tin là đối số đầu tiên
                ListViewItem item = new ListViewItem(row) {
                    // Đặt vị trí ảnh của mỗi item listView giống như được xác định trước trycatch
                    ImageIndex = Imagelist.Images.IndexOfKey(process.Id.ToString())
                };

                // Thêm những item vào listView
                listView_showProcs.Items.Add(item);
            }

            // Đặt imagelist trước mỗi một tiến trình
            listView_showProcs.LargeImageList = Imagelist;
            listView_showProcs.SmallImageList = Imagelist;
        }

        /*
         ====================================================================
         ==============================Huyền=================================
         */
        private void tabPage2_Click(object sender, EventArgs e)
        {
           
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            // Khởi tạo biến lưu hiệu năng của CPU và RAM gán bằng giá trị của thanh tiến trình tương ứng
            float fcpu = pCPU.NextValue();
            float fram = pRAM.NextValue();
            //gán giá trị của thanh tiến trình bằng gtri int của biến tương ứng
            progressBarcpu.Value = (int)fcpu;
            progressBarram.Value = (int)fram;
            //gán giá trị tương ứng bằng kiểu chuỗi của 2 biến fcpu và fram
            lbcpu.Text = string.Format("{0:0.00}%", fcpu);
            lbram.Text = string.Format("{0:0.00}%", fram);
            //lấy giá trị của 2 biến fcpu và fram để vẽ biểu đồ chart1 với các đường tương ứng
            chart1.Series["CPU"].Points.AddY(fcpu);
            chart1.Series["RAM"].Points.AddY(fram);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void listView_showProcs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void progressBarcpu_Click(object sender, EventArgs e)
        {

        }

        private void lbcpu_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void progressBarram_Click(object sender, EventArgs e)
        {

        }

        private void lbram_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /*
        ==========================================================================================
                                                Phần xử lý của Vũ 
        ==========================================================================================
        */

        /*
        ==========================================================================================
                                                Phần xử lý của Bình
        ==========================================================================================
        */

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processList = Process.GetProcesses();
            if (listView_showProcs.SelectedItems.Count > 0)
            {
                //Truyền đi id của tiến trình đó sang cho form 2
                DetailForm form = new DetailForm(processList[listView_showProcs.SelectedIndices[0]].Id.ToString());
                form.ShowDialog();
            }
            
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
