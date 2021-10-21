import java.lang.*;
import java.util.*;

public class Program {

    public static void main(String[] args) {
        print("日本語");

        var num = 3.14;
        print(((Object) num).getClass().getSimpleName());

        String str = "コンピュータ 情報 専門 学校";
        print(str.replace("情報", "Information"));

        // ****************************
        // ヒアストリング
        // ****************************
        String html = """
        <HTML>
          <BODY>
            <H1>$01</H1>
          </BODY>
        </HTML>""";
        html = html.replace( "$01", str );
        print(html);

        StringBuilder sb = new StringBuilder();
        sb.append("bye");
        print( sb.toString() );
        print(str.replace("情報", sb));

        String su = "123";
        int result = Integer.parseInt(su);
        result++;
        result += 2;
        result = result + 2;
        print(result);

        // 整数を文字列に変換
        String text = String.format("%d", result);
        print(text);

        // 簡易的な方法
        text = result + "";
        print(text);

        int[] data = new int[5];
        data[0] = 1;
        data[4] = 5;
        print( data.length );

        for (int item : data) {
            print( item );
        }

        // 初期化
        int[] data2 = { 10, 11, 12 };
        // 通常 for
        for (int i = 0; i < data2.length; i++) {
            print( data2[i] );
        }

        List<String> list = new ArrayList<String>();
        list.add("Java");
        list.add("Scala");
        list.add("Ruby");
        str = list.get(0);
        print( str );
        print( list.size() );



    }

    private static void print(String data) {
        System.out.println(data);
    }
    private static void print( int num ) {
        System.out.println(num);
    }

}
