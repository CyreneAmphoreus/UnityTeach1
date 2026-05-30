# Lesson15 - 光源组件练习

## 教程/小节名称

唐老狮 Unity 教程 - Lesson15 光源组件练习

## 本节目标

通过代码结合点光源模拟一个蜡烛的光源效果，并通过代码结合方向光模拟白天黑夜的变化。

## 已完成内容

- 新建 `Assets/Scripts/Lesson15/` 练习目录。
- 新建 `Lesson15.unity` 场景。
- 新增 `Lesson15.cs`，集中控制本节光源练习逻辑。
- 使用 `Point Light` 作为蜡烛光源。
- 通过 `Transform.Translate` 让点光源在小范围内左右移动，模拟蜡烛轻微摆动。
- 通过修改 `Light.intensity` 让点光源亮度在范围内变化，模拟火光忽明忽暗。
- 使用 `Directional Light` 的旋转模拟白天黑夜变化。
- 新增 `Assets/Materials/Gray.mat` 作为场景材质。
- 将字段名从泛用的 `light` 调整为更明确的 `candleLight`。
- 在 Inspector 中重新绑定并保存 `candleLight` 和 `directionalLight` 引用。

## 做得好的地方

- 能把题目拆成两个独立目标：蜡烛点光源、方向光昼夜变化。
- 没有把练习过度复杂化，当前代码适合用于理解 Light 组件基础属性。
- 能接受“正式项目优化”和“教程练习目标”分开处理，这对学习节奏很好。
- 字段命名从 `light` 改为 `candleLight` 后，可读性更强。

## 当前问题

- 蜡烛摆动和亮度变化使用边界反向逻辑，能完成练习，但视觉上会偏规律、偏机械。
- 这类效果后续做正式项目时，可以再考虑更自然的周期函数或随机扰动。
- 字段改名后曾出现场景仍保存旧字段 `light` 的情况，需要记住重新保存 Inspector 引用。

## 推荐改进方向

- 当前学习阶段保持现有写法即可，重点是理解 `Light` 组件、Transform 控制和 Inspector 引用。
- 后续个人项目中，可以使用 `Mathf.Sin`、`Mathf.PingPong`、噪声或随机范围让蜡烛效果更自然。
- 更完整的昼夜系统可以继续扩展环境光、天空盒、阴影强度、后处理和渲染管线配置。

## 教程写法与当前 Unity 选择

- 教程中通过代码控制 `Light.intensity` 和光源 Transform 的写法在当前 Unity 版本中仍然可用。
- 对初学阶段来说，直接控制 Light 组件是合适的学习方式。
- 当前 Unity 项目如果追求正式昼夜效果，通常不会只旋转方向光，还会联动 Render Settings、Skybox、Ambient Light、Post Processing 或 URP/HDRP 设置。

## 相关提交

- `study: 完成唐老狮教程 - Lesson15 光源组件练习`
