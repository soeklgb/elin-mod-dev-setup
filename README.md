# ElinのMod開発環境の作り方（VSCode + dnSpy）

> [!WARNING]
> まだ書いている途中です！

OSはWindows11を想定しています。

## 1. .NETのインストール

[.NET](https://dotnet.microsoft.com)はElinのMod開発で使うフレームワークです。

まずは.NETをインストールをします。

1. [.NETのダウンロードページ](https://dotnet.microsoft.com/ja-jp/download)から.NET 9.0の.NET SDKをダウンロードします。
2. ダウンロードしたファイルを実行してインストールを完了させます。

.NETをインストールすると`dotnet`コマンドが使えるようになります。

.NETがインストールされていることを確認してみましょう。

1. デスクトップで右クリックして「ターミナルで開く」でWindows PowerShellを開きます。
2. ターミナルで`dotnet --version`を実行して表示されたバージョンが9ならインストールに成功しています（`9.0.100`など）。

## 2. Visual Studio Codeのインストール

[Visual Studio Code](https://code.visualstudio.com/) (VSCode)はカスタマイズ性の高いコードエディターです。
 
 ElinのMod開発でコードを書くときはおもにこのVSCodeを使って書いていきます。

1. [VSCodeの公式サイト](https://code.visualstudio.com/)からVSCodeをダウンロードします
2. ダウンロードしたファイルを実行してインストールを完了させます。

## 3. SampleModのビルド

最低限必要な環境が揃ったので、ゲームのログにテキストを表示するだけのサンプルModのビルドをしてみましょう。

[SampleMod.zip](https://github.com/soeklgb/elin-mod-dev-setup/raw/refs/heads/main/SampleMod.zip)をダウンロードして展開してください。
展開したらSampleModフォルダーをVSCodeで開いてみましょう。
SampleModフォルダーをVSCode上にドラッグアンドドロップすると開けます。

SampleModのビルドには`dotnet build`コマンドを使います。
`Ctrl + @`でVSCodeのターミナルを開いて`dotnet build`を実行します。

コマンドを実行したターミナルのログに`5.2 秒後に 成功しました をビルド`と~~奇妙な文が~~表示されれば、ビルドは成功です。

> [!NOTE]
> `dotnet build`コマンドはカレントディレクトリを対象に実行されます。
> 何らかの理由でカレントディレクトリがSampleModフォルダーでない場合は、`cd`コマンドでカレントディレクトリを変更しましょう。

SampleModではビルドしたModは`Elin/Package`（ElinのModを配置するフォルダー）に作成されるので、Modの動作をすぐに確認できます。

Elinを起動してセーブデータをロードしたとき、ログに「Hello, World!」と表示されていればSampleModは動作しています。

## 4. SampleModの内容

SampleModフォルダーはこのような構造になっています。

```
SampleMod
 ┣━ bin
 ┣━ obj
 ┣━ package.xml
 ┣━ Plugin.cs
 ┗━ SampleMod.csproj
```

`package.xml`は、ElinのModをSteam Workshopにアップロードする際に必要になる設定ファイルです。

`Plugin.cs`は、SampleModの動作が記述されたソースコードです。 **C#** というプログラミング言語で書かれています。

`SampleMod.csproj`は、C#で書かれたプログラムのビルドの設定と動作を記述するファイルです。一般的には **プロジェクトファイル** と呼ばれています。

`bin`フォルダーと`obj`フォルダーはビルド時に作成されるファイルです。ビルドの過程で生成されるファイルや、コンパイルによって生成されたDLLファイルが格納されています。

### package.xml

TODO

### Plugin.cs

TODO

### SampleMod.csproj

TODO

---

## TODO

- VSCodeの拡張機能のインストール
  - `C#`拡張機能（`ms-dotnettools.csharp`）
  - `C# Dev Kit`はいらない？
- dnSpyのインストール
- BepInExのログの表示の仕方
- ドキュメントのリンク集
  - 特に`.csproj`
- .pdb

## 他の解説に任せるもの

- package.xmlの解説
- C#の解説
- Unityの解説
- Harmonyの解説
