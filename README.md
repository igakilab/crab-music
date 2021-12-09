# crab-music
<h1>SetUpManual</h1>
Download - Unity (unity3d.com)から最新版のUnity hubをダウンロードする 
Unity Hubからインストールの項目を選び、Unity 2020.3.16f1をインストールする 

この際、Unityバージョンを加える画面にてWebGL Build Supportにチェックを入れる 

 

CodeからDownload Zipをクリックしてcrab-music-main.zipをダウンロードし、任意の場所に展開する 

Unity Hubのプロジェクトの項目からリストに追加をクリックして、展開したフォルダの中に入っているCrab musicフォルダを選択する。 

 

Unityの編集画面が出たらEdit内にあるProject Settingを選びその中のPlayer内にあるPublishing Settingを選び、その中のCompression FormatをDisabledに設定する。 

 

FileからBuild Settingsを開いて、TitleScene,CountDown,GameScene,GameOverの四つをScene In Build内に追加してチェック欄にチェックマークを付けてからWeb GLの項目からBuild And Runをクリックする。 

※Scene In Build内に追加するには TitleScene.unity, CountDown.unity,GameScene.unity,GameOver.unityの4つのファイルを起動しておいてからAdd Open Scenesをクリックすれば追加される 

 

Web GLのビルドファイルを展開するフォルダを求められるので、以下の条件を満たす任意のフォルダを選択する 

1.ゲーム本体の入っているフォルダ(Crab music)の中に存在するフォルダではない 

2.フォルダのpassのどこかに全角文字が含まれない 

展開できれば下図のようなファイルが追加される(この図では別のリポジトリにビルドファイルを展開している) 

グラフィカル ユーザー インターフェイス, アプリケーション, テーブル, Excel

自動的に生成された説明 

Netlify(https://app.netlify.com/) にアクセスする 

ここからはNetlifyの初期設定してない人向け 

1  アクセスしたらGitHubをクリックする 

2  GitHubアカウントとpasswordを入力する 

3  Create a new teamの画面が出たらEnterpriseを選択する 

4  あとは空欄に記入してGet in touchをクリックする 

5  1～4が完了すれば下図のような画面が出るはず(Sites内は人によって異なる) 

アクセス出来たらSites内の「New site from Git」をクリック 

次にGitHubをクリック 

ビルドしたCRAB MUSICがあるアカウント、リポジトリを選択。 

（今回でいうigakilabのアカウント内にあるcrab-music-playを選択） 
選択したらDeploy siteを選択する(ほかの項目は触らなくてよい)。 

下図のような画面が出たらその中にあるリンクをクリックするとWebGLにゲームがアップロードされていることが確認できる。 
