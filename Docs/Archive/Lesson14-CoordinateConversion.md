# Lesson14 - 坐标转换练习

## 教程/小节名称

唐老狮 Unity 教程 - Lesson14 坐标转换练习

## 本节目标

练习世界坐标与屏幕坐标之间的转换，并在鼠标点击位置对应的世界坐标处创建 Cube。

## 已完成内容

- 新建 `Lesson14.unity` 练习场景，替换原先的预备场景。
- 使用 `Camera.main.WorldToScreenPoint(transform.position)` 将 Cube 的世界坐标转换为屏幕坐标。
- 将转换结果放到 `Start()` 中打印，避免 `Update()` 每帧刷屏。
- 在 `PlayerController.inputactions` 中新增 `Fire` Action，并绑定鼠标左键。
- 使用新 Input System 的 `Fire.performed` 事件创建 Cube。
- 使用 `Input.mousePosition` 获取鼠标屏幕坐标。
- 给鼠标屏幕坐标设置 `z = 10`，再通过 `Camera.main.ScreenToWorldPoint(mousePosition)` 转换为世界坐标。
- 保留旧输入系统写法作为注释对照。

## 做得好的地方

- 能理解 `ScreenToWorldPoint` 的 `z` 表示距离摄像机的深度，而不是普通二维屏幕坐标。
- 能把点击创建 Cube 从旧输入系统扩展到新 Input System。
- 根据审查建议把每帧打印改成 `Start()` 打印一次，避免 Console 刷屏。
- 清理了无用 `using`，并调整了输入事件解绑顺序。

## 当前问题

- `Lesson14.cs` 中的 `pos` 当前只是用于打印一次，后续如果不需要成员字段，可以改为局部变量。
- `Lesson14_2.cs` 中旧输入系统代码仍作为注释保留，适合当前学习阶段；如果后续正式整理，可以进一步简化。

## 推荐改进方向

- 可以继续观察不同 `mousePosition.z` 值对 Cube 生成位置的影响。
- 后续可以尝试通过射线 `Camera.ScreenPointToRay` + 平面/碰撞检测来创建物体，这在实际项目中比固定 z 深度更常见。
- 可以把创建 Cube 的逻辑提取成小方法，方便旧输入系统和新输入系统共用。

## 教程写法与当前 Unity 选择

- `Camera.WorldToScreenPoint` 和 `Camera.ScreenToWorldPoint` 在当前 Unity 版本中仍然可用，是理解坐标转换的基础 API。
- 基础练习中直接使用固定 z 深度很合适；实际项目中鼠标点击放置物体更常用射线检测。

## 相关提交

- `f705624 study: 完成唐老狮教程 - Lesson14 坐标转换练习`
