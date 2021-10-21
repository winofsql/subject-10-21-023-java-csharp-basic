import java.lang.*;

public class Program {

    public static void main(String[] args) {
        print("日本語");

        var num = 3.14;
        print(((Object) num).getClass().getSimpleName());

        String str = "清風 情報 工科 学院";
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
    }

    private static void print(String data) {
        System.out.println(data);
    }
    private static void print( int num ) {
        System.out.println(num);
    }

}