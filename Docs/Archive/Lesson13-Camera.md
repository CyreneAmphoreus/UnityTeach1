# Lesson13 - Camera 组件练习

## 教程/小节名称

唐老狮 Unity 教程 - Lesson13 Camera 组件信息练习

## 本节目标

练习 Camera 组件的分屏显示、跟随目标、Layer 和 Culling Mask 配合，实现多个摄像机在 Game 窗口中的不同显示效果。

## 已完成内容

- 在 `Assets/Scripts/Lesson13/` 下创建两个练习场景。
- 第一题使用两个摄像机实现左右分屏显示。
- 将摄像机挂到坦克相关层级下，实现跟随坦克移动。
- 第二题创建 A、B 两个物体，并新增 `A`、`B` 两个 Layer。
- 使用两个摄像机分别只渲染 Layer A 和 Layer B。
- 通过 Camera 的 Viewport Rect、Culling Mask、Clear Flags 和 Depth 实现同一个 Game 窗口同时看到 A 和 B。
- 新建 `Lesson14` 文件夹和预备场景，用于下一 P 课程学习。

## 做得好的地方

- 能主要通过 Unity Editor 配置完成题目，没有为 Camera 练习额外写不必要脚本。
- 能理解 Camera Viewport Rect 可用于分屏。
- 能理解 Layer 和 Culling Mask 是控制摄像机可见对象的关键。
- 在发现两道题不适合放同一个场景后，及时拆分为独立练习场景。
- 根据审查建议把第二题的 A 摄像机 Culling Mask 改为只渲染 A 层，配置更严格。

## 当前问题

- `Lesson11.unity` 中保留了做第一题时产生的摄像机 Transform 变化，这是练习过程中尽量还原后的结果。
- Lesson13 主要依赖场景配置，提交前要特别检查 `.unity` 场景文件和 `ProjectSettings/TagManager.asset` 是否一起提交。

## 推荐改进方向

- 多摄像机练习中，可以给摄像机明确命名，例如 `Camera_LeftFollow`、`Camera_RightTurret`、`Camera_AOnly`、`Camera_BOnly`。
- 分屏时重点检查 Viewport Rect 的 `x`、`y`、`width`、`height`。
- 多摄像机叠加时重点检查 Clear Flags、Depth 和 Culling Mask，避免某个摄像机清屏覆盖另一个摄像机的结果。

## 教程写法与当前 Unity 选择

- 使用多个 Camera、Viewport Rect、Culling Mask、Depth 等方式控制画面显示，在当前 Unity 版本中仍然可用。
- 实际项目中复杂镜头可结合 Cinemachine、URP Camera Stack、Render Texture，但当前阶段先掌握原生 Camera 组件更重要。

## 相关提交

- `7cb55d7 study: 完成唐老狮教程 - Lesson13 Camera 组件练习`
