# TangLessonsNotes

本文件现在作为唐老狮教程知识点索引使用。完整知识点记录按 Lesson 归档到 `Docs/Archive/`。

日常检查时优先读取 `Docs/CurrentStatus.md`；需要查某节教程细节时，再打开对应 Archive 文件。

## 当前环境

- Unity 版本：`6000.3.10f1`
- Input System：`1.18.0`
- 教程来源：唐老狮 Unity 教程练习
- 教程时间背景：约 2022 年

## 知识点索引

### 输入系统

归档文件：[Lesson11 - Input System 与坦克控制](Archive/Lesson11-InputSystem.md)

重点：

- 旧输入系统仍适合理解每帧读取输入，也常见于存量项目。
- 新 Input System 更适合结构化输入配置、多设备和可维护项目。
- 运行时应避免新旧控制脚本同时启用并控制同一对象。

### Screen 扩展、滚轮与炮管俯仰

归档文件：[Lesson12 - Screen 扩展与炮管俯仰](Archive/Lesson12-ScreenAndGunPitch.md)

重点：

- `Mathf.Clamp` 只返回限制后的值，不会自动修改 Transform。
- `Rotate()` 是累加旋转，限制俯仰角更适合直接设置 `localEulerAngles`。
- Unity 欧拉角常显示为 `0~360`，限制负角度前需要转换成 signed angle。

### Camera 组件

归档文件：[Lesson13 - Camera 组件练习](Archive/Lesson13-Camera.md)

重点：

- Viewport Rect 可用于分屏。
- Layer + Culling Mask 可让不同摄像机看到不同对象。
- 多 Camera 同屏时要同时关注 Clear Flags、Depth 和 Culling Mask。
- 实际项目可继续学习 Cinemachine、URP Camera Stack、Render Texture。

### 坐标转换

归档文件：[Lesson14 - 坐标转换练习](Archive/Lesson14-CoordinateConversion.md)

重点：

- `WorldToScreenPoint` 把世界坐标转换为屏幕坐标。
- `ScreenToWorldPoint` 把屏幕坐标转换为世界坐标，但必须提供有意义的 `z` 深度。
- 鼠标点击场景放置物体时，实际项目中更常用 `ScreenPointToRay` + 射线检测。

## 后续记录规则

- 每完成一个新 Lesson，在 `Docs/Archive/` 中新增对应文件。
- 本文件只补充索引和跨 Lesson 的知识点入口，不再写长篇流水内容。
- 如果一个知识点反复出现，可以在本文件中保留短摘要，并把详细过程放到归档文件。
