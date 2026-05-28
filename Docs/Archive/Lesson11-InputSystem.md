# Lesson11 - Input System 与坦克控制

## 教程/小节名称

唐老狮 Unity 教程 - Lesson11 输入系统与坦克控制练习

## 本节目标

练习使用旧输入系统和新 Input System 控制坦克移动、车体旋转和炮塔旋转，并理解输入系统事件订阅、对象层级和 Inspector 引用。

## 已完成内容

- 使用 `PlayerController.inputactions` 生成的输入类读取 `Move` 和 `Look`。
- 在脚本启用和禁用时订阅、取消订阅输入事件。
- 使用 `W/S` 控制坦克沿自身前后方向移动。
- 将 `A/D` 从左右平移改为绕 Y 轴旋转车体。
- 使用鼠标 X 控制 `Tank_Head` 炮塔旋转。
- 将 `Tank_Head` 从 `transform.Find("Tank_Head")` 改为 `[SerializeField] private Transform tankHead;`，并在 Inspector 中绑定引用。
- 保留旧输入系统版本作为对照学习。
- 记录并排查了空 GameObject 上残留 `Lesson11` 脚本导致多个实例执行的问题。

## 做得好的地方

- 能根据“坦克不应该左右平移”这个真实对象行为反推代码逻辑。
- 能通过日志确认 `transform.Find("Tank_Head")` 的查找结果。
- 能从 Console 输出反推多个脚本实例导致的问题。
- 能理解 `Debug.Log(..., this)` 比 `print` 更适合定位脚本挂载对象。
- 能结合国内项目环境判断旧输入系统仍有学习价值。

## 当前问题

- 新旧输入系统对照对象需要保持命名和启用状态清楚，避免重复控制。
- 关键引用依赖 Inspector，修改 Prefab 或场景时需要确认引用仍然有效。

## 推荐改进方向

- 后续可以学习 `IPlayerActions` 回调接口写法，减少手动订阅遗漏。
- 可以继续对比 `PlayerInput` 组件和纯代码输入管理方式。
- 对关键引用可加入空值检查和定位日志。

## 教程写法与当前 Unity 选择

- 旧输入系统：简单直观，适合早期学习和存量项目。
- 新 Input System：适合结构化输入配置、多设备和可维护项目。
- 初学阶段保留新旧两套对照是合理的，但实际运行时只应启用一套控制脚本。

## 相关提交

- `97b3d35 study: 完成唐老狮教程 - Lesson11 输入系统练习`
- `68f1341 study: 完成唐老狮教程 - Lesson11 坦克控制优化`
