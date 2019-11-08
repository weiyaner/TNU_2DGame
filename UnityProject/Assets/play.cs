using UnityEngine;

public class play : MonoBehaviour
{
    // 定義欄位 Field
    // 修飾詞       欄位類型 欄位名稱 （指定 值）結尾
    // 預設 private 私人 （在屬性面板上隱藏）
    float speed = 3.5f;              // 浮點數  結尾要有 f
    int jump = 300;                 // 整數
    bool isGround = false;         //布林值 - true ` false
    string name = "NHI";          // 字串 - 需要用雙引號
}