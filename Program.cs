using System.Collections.Generic;
using System.Collections;
using System.Text;
using System;

namespace compare_cs_01
{
    public class Program {
        public static void Main(string[] args) {
            print("日本語");

            var num = 3.14;
            print(num.GetType().ToString());

            string str = "コンピュータ 情報 専門 学校";
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

            int[] data = new int[5];
            data[0] = 1;
            data[4] = 5;
            print( data.Length );

            foreach (var item in data) {
                print( item );
            }

            // 初期化
            int[] data2 = { 10, 11, 12 };
            // 通常 for
            for (int i = 0; i < data2.Length; i++) {
                print( data2[i] );
            }

            // セットするクラスを指定しないリスト
            ArrayList list = new ArrayList();
            list.Add("Java");
            list.Add("Scala");
            list.Add("Ruby");
            // 取り出すときに元のクラスにキャスト
            str = (string)list[0];
            print( str );
            print( list.Count );

            List<string> clist = new List<string>();
            clist.Add("Java");
            clist.Add("Scala");
            clist.Add("Ruby");
            str = clist[0];
            print( str );
            print( clist.Count );

        }

        private static void print( string data ) {
            Console.WriteLine(data);
        }
        private static void print( int data ) {
            Console.WriteLine(data);
        }
    }
}
