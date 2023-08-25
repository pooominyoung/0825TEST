using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace test
{
    public partial class Form1 : Form
    {   
        //시리얼 포트 변수
        private SerialPort serialPort = new SerialPort();

        public Form1()
        {
            InitializeComponent();
            InitializeSerialPort();
        }

        private void InitializeSerialPort()
        {
            serialPort.BaudRate = 9600;
            serialPort.DataBits = 8;
            serialPort.StopBits = StopBits.One;
            serialPort.Parity = Parity.None;
            serialPort.DataReceived += SerialPort_DataReceived;
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (e.EventType == SerialData.Chars)
            {
                string receivedData = serialPort.ReadLine(); // 시리얼 데이터 읽기
                Console.WriteLine("Received Data: " + receivedData);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 시리얼 포트 목록을 콤보 박스에 로드
            string[] portNames = SerialPort.GetPortNames();
            PortNumber.Items.AddRange(portNames);
        }


        private void conn_Click(object sender, EventArgs e)
        { // 연결 버튼 클릭
            if (PortNumber.SelectedItem != null)
            {
                try
                {
                    if (serialPort.IsOpen)
                    {
                        serialPort.Close(); 
                    }

                    serialPort.PortName = PortNumber.SelectedItem.ToString();
                    serialPort.Open();
                    message.Text = serialPort.PortName + " CONN";
                    Console.WriteLine(serialPort.PortName + " CONN");
                }
                catch (Exception ex)
                {
                    message.Text = "Connection ERROR: " + ex.Message;
                    Console.WriteLine("Connection ERROR: " + ex.Message);
                }
            }
            else
            {
                message.Text = "Select a COM port first.";
            }
        }


        private void led_01_on_Click(object sender, EventArgs e)
        {
            SendSerialData("LED1_ON");
            Console.WriteLine("LED_01_ON CLICKED");
            if (ReceiveAckFromDevice()) // 기기로부터 응답을 받았다면
            {
                message.Text = "LED_01_ON SUCCESS";
            }
            else
            {
                message.Text = "LED_01_ON FAILED"; 
            }
        }

        private void led_01_off_Click(object sender, EventArgs e)
        {
            SendSerialData("LED1_OFF");
            Console.WriteLine("LED_01_OFF CLICKED");
            if (ReceiveAckFromDevice()) // 기기로부터 응답을 받았다면
            {
                message.Text = "LED_01_OFF SUCCESS";
            }
            else
            {
                message.Text = "LED_01_OFF FAILED"; // 성공하지 않았을 때 실패 메시지를 표시할 수 있습니다.
            }
        }

        private void led_02_on_Click(object sender, EventArgs e)
        {
            SendSerialData("LED2_ON");
            Console.WriteLine("LED_02_ON CLICKED");
            if (ReceiveAckFromDevice()) // 기기로부터 응답을 받았다면
            {
                message.Text = "LED_02_ON SUCCESS";
            }
            else
            {
                message.Text = "LED_02_ON FAILED"; // 성공하지 않았을 때 실패 메시지를 표시할 수 있습니다.
            }
        }

        private void led_02_off_Click(object sender, EventArgs e)
        {
            SendSerialData("LED2_OFF");
            Console.WriteLine("LED_02_OFF CLICKED");
            if (ReceiveAckFromDevice()) // 기기로부터 응답을 받았다면
            {
                message.Text = "LED_02_OFF SUCCESS";
            }
            else
            {
                message.Text = "LED_02_OFF FAILED"; // 성공하지 않았을 때 실패 메시지를 표시할 수 있습니다.
            }
        }

        private bool ReceiveAckFromDevice()
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    string receivedData = serialPort.ReadLine(); // 기기로부터 데이터 읽기
                    Console.WriteLine("Received Data from Device: " + receivedData);
                    return receivedData == "ACK"; // 기기로부터 'ACK'를 받으면 성공으로 처리
                }
                else
                {
                    message.Text = "Serial Port is not open.";
                    return false;
                }
            }
            catch (Exception ex)
            {
                message.Text = "Error: " + ex.Message;
                return false;
            }
        }

        private void SendSerialData(string data)
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    serialPort.WriteLine(data); // 데이터 전송
                    message.Text = "Command Sent: " + data; // 텍스트 박스에 명령 표시
                }
                else
                {
                    message.Text = "Serial Port is not open.";
                }
            }
            catch (Exception ex)
            {
                message.Text = "Error: " + ex.Message;
            }
        }


    }
}
