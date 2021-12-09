# crab-music
<h1>SetUpManual</h1>
Download - Unity (unity3d.com)から最新版のUnity hubをダウンロードする 

![bandicam 2021-12-09 14-57-14-076](https://user-images.githubusercontent.com/72372407/145347364-4f54ea46-6946-4476-a49d-e65730c9e646.jpg)

Unity Hubからインストールの項目を選び、Unity 2020.3.16f1をインストールする 

![bandicam 2021-12-09 14-59-29-807](https://user-images.githubusercontent.com/72372407/145347394-6ca44c41-4b56-4b11-b704-10002fbf6574.jpg)

この際、Unityバージョンを加える画面にてWebGL Build Supportにチェックを入れる 

![bandicam 2021-12-09 15-03-13-344](https://user-images.githubusercontent.com/72372407/145347343-2dc9c4b3-4b5b-43ae-bbb2-388bc63fd403.jpg)

CodeからDownload Zipをクリックしてcrab-music-main.zipをダウンロードし、任意の場所に展開する 

Unity Hubのプロジェクトの項目からリストに追加をクリックして、展開したフォルダの中に入っているCrab musicフォルダを選択する。 

![bandicam 2021-12-09 15-03-46-324](https://user-images.githubusercontent.com/72372407/145347309-b0a687e5-386f-4a8a-9851-01dbfd8b076d.jpg)
![bandicam 2021-12-09 15-06-09-141](https://user-images.githubusercontent.com/72372407/145347238-9bc785cc-273d-48c3-9dd5-e2ea0a6ce728.jpg)
![bandicam 2021-12-09 15-04-16-244](https://user-images.githubusercontent.com/72372407/145347266-f27162dc-50e0-49e0-8e8a-b4bb018571d4.jpg)


Unityの編集画面が出たらEdit内にあるProject Settingを選びその中のPlayer内にあるPublishing Settingを選び、その中のCompression FormatをDisabledに設定する。 

 ![bandicam 2021-12-09 15-13-11-034](https://user-images.githubusercontent.com/72372407/145347219-979aae5d-fe25-4848-a376-c8939aa63025.jpg)

FileからBuild Settingsを開いて、TitleScene,CountDown,GameScene,GameOverの四つをScene In Build内に追加してチェック欄にチェックマークを付けてからWeb GLの項目からBuild And Runをクリックする。 

※Scene In Build内に追加するには TitleScene.unity, CountDown.unity,GameScene.unity,GameOver.unityの4つのファイルを起動しておいてからAdd Open Scenesをクリックすれば追加される 

 ![bandicam 2021-12-09 15-13-57-924](https://user-images.githubusercontent.com/72372407/145347095-c8db2899-7743-4ad3-b0d5-0f93f704fc1e.jpg)


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

<hr/>

<h1>UserManual</h1> 

<h2>ゲーム内容</h2> 
カニを左右に動かし、音楽に合わせて落ちてくる音符をキャッチするゲームです。 
タイミングよく音符をキャッチするとスコアが獲得でき、演奏終了時に最終スコアが表示される。 

 

<h2>動作環境</h2> 
PCのみ 

<h2>必要なもの</h2> 
マウス,キーボード 
対応ブラウザ(Google Chrome, Firefox) 

<h2>ゲームの始め方・操作方法 </h2>
タイトル画面が表示されたら左クリックをしてください。するとカウントダウンの後にゲームがスタートします。演奏中は左右の矢印キーでカニが移動し、判定枠に音符が重なったときにスペースキーを押すことで音符をキャッチでき、スコアが獲得できます。 
演奏が終了したときに最終スコアが表示され、左クリックでタイトル画面に戻る。 

<h2>注意事項 </h2>
演奏終了してタイトルに戻って始めてもスコアがリセットされないため,もう一度するときはブラウザを再起動(F5)させてください。 
