using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFood.DAL_DataLayer
{
    public class DataProvider
    {
        private DataProvider() { }
        private static DataProvider instance;//thể hiện của class DataProvider(gọi tới sẽ là duy nhất)

        //chuỗi kết nối
        //DESKTOP-PGRM0OK hoa
        //DESKTOP-4KQ12ML: VA
        //DESKTOP-MUJKC6P: HẢI
        private String connectionStr = "Data Source=DESKTOP-PGRM0OK;Initial Catalog=CHUOICUAHANGDOAN;Integrated Security=True";

        public static DataProvider Instance {
            get {
                if (instance == null) instance = new DataProvider();
                return DataProvider.instance;
            }
            private set { DataProvider.instance = value;}
        }

        

        public void ConnectSql()
        {
            using (SqlConnection connection = new SqlConnection(connectionStr))
            { //using: sau khi khối lệnh phía trong chạy xong biến connection tự giải phóng

                connection.Open();

                SqlCommand command = new SqlCommand("", connection);

                connection.Close();
            }
        }

        //kết nối csdl + thực hiện query
        public DataTable ExecuteQuery(String query, object[] parameter = null)
        {
            DataTable data = new DataTable();//chứa talble tài khoản
            using (SqlConnection connection = new SqlConnection(connectionStr))
            { //using: sau khi khối lệnh phía trong chạy xong biến connection tự giải phóng

                //mở kết nối để lấy dữ liệu
                connection.Open();
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);//lệnh thực thi câu truy vấn tại kết nối "connection"

                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }


                    //trung gian để lấy data
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    //đưa dữ liệu vào datatable
                    adapter.Fill(data);
                }
                        catch
                {
                    MessageBox.Show("Có lỗi xảy ra! Kiểm tra lại!", "Thông báo", MessageBoxButtons.OK);
                }
            //đóng kết nối sql để tránh việc quá nhiều dữ liệu cùng một lúc đổ vê
            connection.Close();
            }

            return data;

        }

        //kết nối csdl + trả về số lượng dòng thành công khi thực hiện query
        public int ExecuteNonQuery(String query, object[] parameter = null)
        {
            int data = 0;//số dòng thêm thành công

            using (SqlConnection connection = new SqlConnection(connectionStr))
            { //using: sau khi khối lệnh phía trong chạy xong biến connection tự giải phóng

                //mở kết nối để lấy dữ liệu
                connection.Open();
                //try
                //{
                    SqlCommand command = new SqlCommand(query, connection);//lệnh thực thi câu truy vấn tại kết nối "connection"

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();//số lần thêm thành công
                //}
                //catch
                //{
                //    MessageBox.Show("Có lỗi xảy ra! Kiểm tra lại!", "Thông báo", MessageBoxButtons.OK);
                //}
                //đóng kết nối sql để tránh việc quá nhiều dữ liệu cùng một lúc đổ vê
                connection.Close();
            }

            return data;
        }

        //trả về count *
        public object ExecuteScalar(String query, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectionStr))
            { //using: sau khi khối lệnh phía trong chạy xong biến connection tự giải phóng

                //mở kết nối để lấy dữ liệu
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);//lệnh thực thi câu truy vấn tại kết nối "connection"
                try { 
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();
                }
                catch 
                {
                    MessageBox.Show("Có lỗi xảy ra! Kiểm tra lại!", "Thông báo", MessageBoxButtons.OK);
                }
                //đóng kết nối sql để tránh việc quá nhiều dữ liệu cùng một lúc đổ vê
                connection.Close();
            }

            return data;
        }
    }
}
