# 托盤擺放優化模型

此項目實現了一個基於 C# 和 CPLEX 的三維托盤擺放優化模型，目標是最小化托盤的使用數量。

## 目標
- 最小化托盤使用數量
- 確保每個料號符合訂單需求

## 使用說明
1. 安裝 [CPLEX](https://www.ibm.com/products/ilog-cplex-optimization-studio)
2. 克隆此倉庫到本地：`git clone https://github.com/yourusername/your-repo-name`
3. 在 Visual Studio 中打開解決方案並運行

## 文件結構
- `README.md` - 此說明文件
- `Program.cs` - 主程序文件
- `Model.cs` - 儲存數學模型和參數的文件
- `Solver.cs` - 儲存求解邏輯的文件
- `Data/InputData.cs` - 儲存輸入數據的文件

## 參考
- [托盤擺放優化模型說明](./documentation/model_description.pdf)
