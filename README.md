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

まず、[SampleMod.zip](https://github.com/soeklgb/elin-mod-dev-setup/raw/refs/heads/main/SampleMod.zip)をダウンロードして展開してください。展開したSampleModフォルダーをVSCodeで開いてみましょう。SampleModフォルダーをVSCode上にドラッグアンドドロップすると開けます。

SampleModフォルダーはこのような構造になっています。

```
SampleMod
 ┣━ package.xml
 ┣━ Plugin.cs
 ┗━ SampleMod.csproj
```

`package.xml`は、ElinのModをSteam Workshopにアップロードする際に必要になる設定ファイルです。

`Plugin.cs`は、SampleModの動作が記述されたソースコードです。 **C#** というプログラミング言語で書かれています。

`SampleMod.csproj`は、C#で書かれたプログラムのビルドの設定と動作を記述するファイルです。一般的には **プロジェクトファイル** と呼ばれています。

SampleModのビルドには`dotnet build`コマンドを使います。
`Ctrl + @`でVSCodeのターミナルを開いて`dotnet build`を実行してみましょう。

> [!NOTE]
> `dotnet build`コマンドはカレントディレクトリを対象に実行されます。
> 何らかの理由でカレントディレクトリがSampleModフォルダーでない場合は`cd`コマンドでカレントディレクトリを変更しましょう。

ログに`5.2 秒後に 成功しました をビルド`と~~奇妙な文が~~表示されていれば、ビルドは成功です。

---

- Elinを起動して動作確認をします
- SampleModフォルダに`bin`と`obj`が生成されます
- `bin`フォルダの中に動作可能なModのファイルが生成されます
- `bin`フォルダの中からElinのPackageフォルダへのコピーは自動で行われます（`SampleMod.csproj`で設定されています）
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
