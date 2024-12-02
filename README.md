# ElinのMod開発環境の作り方（VSCode + dnSpy）

> [!WARNING]
> まだ書いている途中です！

OSはWindows11を想定しています。

## 1. .NETのインストール

[.NET](https://dotnet.microsoft.com)はElinのModのプログラミングで使うフレームワークです。
まずは.NETをインストールをします。

1. [.NETのダウンロードページ](https://dotnet.microsoft.com/ja-jp/download)から.NET 9.0の.NET SDKをダウンロードします。
2. ダウンロードしたファイルを実行してインストールを完了させます。

.NETをインストールすると`dotnet`コマンドが使えるようになります。
.NETがインストールされていることを確認してみましょう。

1. デスクトップで右クリックして「ターミナルで開く」でWindows PowerShellを開きます。
2. ターミナルで`dotnet --version`を実行して表示されたバージョンが9ならインストールに成功しています（`9.0.100`など）。

## 2. Visual Studio Codeのインストール

[Visual Studio Code](https://code.visualstudio.com/)
 (VSCode)はカスタマイズ性の高いコードエディターです。ElinのMod開発でコードを書くときはおもにこのVSCodeを使って書いていきます。

1. [VSCodeの公式サイト](https://code.visualstudio.com/)からVSCodeをダウンロードします
2. ダウンロードしたファイルを実行して表示されるウィンドウの手順にしたがってインストールを完了させます。
  - 途中で出る「デスクトップ上にアイコンを作成する」にチェックを入れておくとよいでしょう

## 3. SampleMod

> [!NOTE]
> ここからはほぼ箇条書きになってます

```
SampleMod
 ┣━ package.xml
 ┣━ Plugin.cs
 ┣━ preview.jpg
 ┣━ SampleMod.csproj
 ┗━ SourceCard.xml
```

データは[Excelデータをインポートしてキャラやアイテムを追加してみる](https://docs.google.com/document/d/e/2PACX-1vR3GPx71Xnjfme6PtdqNnS5GnxlOFr2A8KdzH8bYTEwEOCgeVYROi3YaMQ2_h4qsySU_BORHKXPUi9i/pub)からお借りしました。

- [SampleMod.zip](https://github.com/soeklgb/elin-mod-dev-setup/raw/refs/heads/main/SampleMod.zip)をダウンロードして展開してください
- VSCodeでSampleModフォルダーを開いてください
- `Ctrl+@`でVSCodeのターミナルを開いてください
- 現在のパスがSampleModであることを確認してください
- `dotnet build`コマンドでSampleModをビルドします
- SampleModフォルダに`bin`と`obj`が生成されます
- `bin`フォルダの中に動作可能なModのファイルが生成されます
- `bin`フォルダの中からElinのPackageフォルダへのコピーは自動で行われます（`SampleMod.csproj`で設定されています）
- [Excelデータをインポートしてキャラやアイテムを追加してみる](https://docs.google.com/document/d/e/2PACX-1vR3GPx71Xnjfme6PtdqNnS5GnxlOFr2A8KdzH8bYTEwEOCgeVYROi3YaMQ2_h4qsySU_BORHKXPUi9i/pub)と同じように動作するはずです
- SampleModが動作しているかの確認は[こちら](https://discord.com/channels/208391609778307075/1213053125590777866/1255361975907651634)を参考にしてください
- `dotnet build`でビルドするとModフォルダにデバッグ用のファイル(`.pdb`)が生成されます。配布しても問題ありませんが、`dotnet build -c Release`を使えば`.pdb`を生成させずにビルドできます（`SampleMod.csproj`で設定されています）
- Modの配布の仕方に関する情報は[開発小部屋](https://ylvania.org/elin_dev.html)にあります

## TODO

- VSCodeの拡張機能のインストール
  - `C#`拡張機能（`ms-dotnettools.csharp`）
  - `C# Dev Kit`はいらない？
- dnSpyのインストール
- `.csproj`の解説
- BepInExのログの表示の仕方
- ドキュメントのリンク集
  - 特に`.csproj`

## 他の解説に任せるもの

- package.xmlの解説
- C#の解説
- Unityの解説
- Harmonyの解説
