using System.Text;
using System;

namespace cs_basic
{
    public class Program {
        public static void Main(string[] args) {
            print("日本語");

            var num = 3.14;
            print(num.GetType().ToString());

            string str = "清風 情報 工科 学院";
            print(str.Replace("情報", "Information"));

            // ****************************
            // ヒアストリング
            // ****************************
            string html = @"
            <HTML>
            <BODY>
                <H1>$01</H1>
            </BODY>
            </HTML>";
            html = html.Replace( "$01", str );
            print(html);

            // ****************************
            // $ で埋め込み
            // ****************************
            html = @$"
            <HTML>
            <BODY>
                <H1>{str}</H1>
            </BODY>
            </HTML>";
            print(html);

            StringBuilder sb = new StringBuilder();
            sb.Append("bye");
            print( sb.ToString() );
            print(str.Replace("情報", sb.ToString()));

            string su = "123";
            int result = Int32.Parse(su);
            result++;
            result += 2;
            result = result + 2;
            print(result);

            // ****************************
            // 整数を文字列に変換
            // ****************************
            string text = String.Format("{0}", result);
            print(text);
            print( $"{result}" );

            // 簡易的な方法
            text = result + "";
            print(text);
        }

        private static void print( string data ) {
            Console.WriteLine(data);
        }
        private static void print( int data ) {
            Console.WriteLine(data);
        }
    }
}
