using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextureAnim : MonoBehaviour {

    [SerializeField]
    string dirPath;     // 連番画像が保存されているディレクトリ

    // コマ表示キュー
    Queue<System.IO.FileInfo> fileQueue;

    // 表示用テクスチャ
    Texture2D tex;
    RawImage AnimImage;

    void Start () {
        AnimImage = GetComponent<RawImage>();

        // ディレクトリ内のpngファイル一覧を取得
        //   -> キューに入れる
        System.IO.DirectoryInfo info = new System.IO.DirectoryInfo(dirPath);
        fileQueue = new Queue<System.IO.FileInfo>(info.GetFiles("*.tif"));

        // テクスチャオブジェクトを作成しておく
        tex = new Texture2D(256, 256, TextureFormat.RGB24, false);
        AnimImage.texture = Texture2D.blackTexture;
    }
    
    void Update () {

        if (fileQueue.Count <= 0)
        {
            // 全部表示したので何もしない
            return;
        }

        // ファイルからテクスチャデータ読み込み
        System.IO.FileInfo targetImage = fileQueue.Dequeue();
        System.IO.FileStream stream = targetImage.OpenRead();
        var data = new byte[stream.Length];
        stream.Read(data, 0, (int)stream.Length);
        tex.LoadImage(data);

        // RawImageにテクスチャとして設定
        AnimImage.texture = tex;
    }
}