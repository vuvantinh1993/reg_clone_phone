using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tool_regnick
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task t = new Task(() =>
            {
                Auto();
            });
            t.Start();
        }
        void Regchrome()
        {
            Task t = new Task(() =>
            {


            });
            t.Start();
        }


        void Auto()
        {
            List<string> devices = new List<string>();
            var listdevices = KAutoHelper.ADBHelper.GetDevices();

            foreach (var deviceID in listdevices)
            {
                KAutoHelper.ADBHelper.Tap(deviceID, 671, 1689);
                Sleep(20000);
                KAutoHelper.ADBHelper.Tap(deviceID, 540, 1855);
                KAutoHelper.ADBHelper.Tap(deviceID, 524, 1450);

                // từ chối dnah bạ
                KAutoHelper.ADBHelper.Tap(deviceID, 528, 1257);
                KAutoHelper.ADBHelper.Tap(deviceID, 528, 1257);
                KAutoHelper.ADBHelper.Tap(deviceID, 547, 1990);


                // nhập tên
                KAutoHelper.ADBHelper.InputText(deviceID, "Vux");

                KAutoHelper.ADBHelper.Tap(deviceID, 733, 581);
                KAutoHelper.ADBHelper.InputText(deviceID, "Vaan Tinhr");

                KAutoHelper.ADBHelper.Tap(deviceID, 524, 828);

                // ngày tháng năm sinh
                KAutoHelper.ADBHelper.Tap(deviceID, 358, 817);
                KAutoHelper.ADBHelper.InputText(deviceID, "17");
                KAutoHelper.ADBHelper.Tap(deviceID, 544, 721);
                KAutoHelper.ADBHelper.Key(deviceID, KAutoHelper.ADBKeyEvent.KEYCODE_DEL);
                KAutoHelper.ADBHelper.InputText(deviceID, "11");
                KAutoHelper.ADBHelper.Tap(deviceID, 721, 713);
                KAutoHelper.ADBHelper.InputText(deviceID, "1993");
                KAutoHelper.ADBHelper.Tap(deviceID, 532, 1134);

                // giói tinh
                KAutoHelper.ADBHelper.Tap(deviceID, 92, 759);
                KAutoHelper.ADBHelper.Tap(deviceID, 540, 1458);

                // very mail
                KAutoHelper.ADBHelper.Tap(deviceID, 524, 1497);
                KAutoHelper.ADBHelper.InputText(deviceID, "bk1e0ggf@linshiyouxiang.net");
                KAutoHelper.ADBHelper.Tap(deviceID, 532, 775); // tiếp
                KAutoHelper.ADBHelper.InputText(deviceID, "123456a@");
                KAutoHelper.ADBHelper.Tap(deviceID, 540, 867); // tiếp


                // không tải danh bạ
                KAutoHelper.ADBHelper.Tap(deviceID, 594, 1276);
                Sleep(15000);

                // đang nhập 1 lần ấn
                KAutoHelper.ADBHelper.Tap(deviceID, 779, 1350);
                KAutoHelper.ADBHelper.Tap(deviceID, 532, 1489);

                // very mail
                KAutoHelper.ADBHelper.InputText(deviceID, "48449");
                KAutoHelper.ADBHelper.Tap(deviceID, 555, 755);

                // bỏ qua tất cả
                KAutoHelper.ADBHelper.Tap(deviceID, 988, 184);
                KAutoHelper.ADBHelper.Tap(deviceID, 524, 1361);
                KAutoHelper.ADBHelper.Tap(deviceID, 988, 184);
                KAutoHelper.ADBHelper.Tap(deviceID, 513, 1292);

                // lấy đường dẫn trang cá nhân
                KAutoHelper.ADBHelper.Tap(deviceID, 88, 470);
                KAutoHelper.ADBHelper.Tap(deviceID, 69, 172);
                KAutoHelper.ADBHelper.Tap(deviceID, 933, 1269);
                KAutoHelper.ADBHelper.Tap(deviceID, 968, 1392);
                KAutoHelper.ADBHelper.Tap(deviceID, 521, 1867);

                // ghi file patch
                KAutoHelper.ADBHelper.Key(deviceID, KAutoHelper.ADBKeyEvent.KEYCODE_APP_SWITCH);
                KAutoHelper.ADBHelper.Tap(deviceID, 251, 1968);
                KAutoHelper.ADBHelper.Tap(deviceID, 559, 1133);
                KAutoHelper.ADBHelper.Tap(deviceID, 525, 1346);
                KAutoHelper.ADBHelper.Tap(deviceID, 590, 1354);
                KAutoHelper.ADBHelper.Tap(deviceID, 547, 1512);
                KAutoHelper.ADBHelper.Key(deviceID, KAutoHelper.ADBKeyEvent.KEYCODE_ENTER);
                KAutoHelper.ADBHelper.Tap(deviceID, 976, 192);


                // clear app
                KAutoHelper.ADBHelper.Key(deviceID, KAutoHelper.ADBKeyEvent.KEYCODE_APP_SWITCH);
                KAutoHelper.ADBHelper.Tap(deviceID, 251, 1968);
                KAutoHelper.ADBHelper.Tap(deviceID, 729, 2037);
                KAutoHelper.ADBHelper.Tap(deviceID, 528, 1744);
                KAutoHelper.ADBHelper.Tap(deviceID, 798, 2041);


                // về màn hình chính
                KAutoHelper.ADBHelper.Key(deviceID, KAutoHelper.ADBKeyEvent.KEYCODE_HOME);

                // bất tắt wifi
                KAutoHelper.ADBHelper.Key(deviceID, KAutoHelper.ADBKeyEvent.KEYCODE_HOME);
                KAutoHelper.ADBHelper.Swipe(deviceID, 532, 18, 532, 875, 500);
                KAutoHelper.ADBHelper.Tap(deviceID, 540, 438);
                Sleep(5000);
                KAutoHelper.ADBHelper.Tap(deviceID, 540, 438);
                KAutoHelper.ADBHelper.Key(deviceID, KAutoHelper.ADBKeyEvent.KEYCODE_HOME);
                // chọn ảnh đại diện
                //KAutoHelper.ADBHelper.Tap(deviceID, 590, 1875);
                //KAutoHelper.ADBHelper.Tap(deviceID, 783, 1284);
                //// cần trượt trong list ảnh
                //KAutoHelper.ADBHelper.Tap(deviceID, 204, 1585); // con 1 ảnh bất kì
                //KAutoHelper.ADBHelper.Tap(deviceID, 984, 172);
                //KAutoHelper.ADBHelper.Tap(deviceID, 992, 176); // lưu ảnh đại diện
                ////Sleep(5);

                //// bỏ qua tải danh bạ
                //KAutoHelper.ADBHelper.Tap(deviceID, 972, 184);
                //KAutoHelper.ADBHelper.Tap(deviceID, 528, 1369);
                //KAutoHelper.ADBHelper.Tap(deviceID, 984, 180);
                //KAutoHelper.ADBHelper.Tap(deviceID, 516, 1292);

                //// lưuu tông tin đăng nhập
                //KAutoHelper.ADBHelper.Tap(deviceID, 810, 2084);

                Task t = new Task(() =>
                {


                });
                t.Start();
            }
        }

        void Sleep(int delay)
        {
            while (delay > 0)
            {
                Thread.Sleep(1000);
                delay -= 1000;
            }
        }
    }
}
