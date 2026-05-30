# LearningProgress

本文件现在作为学习进度索引和最近变更记录使用。完整小节总结按 Lesson 归档到 `Docs/Archive/`。

日常检查时优先读取：

- `Docs/CurrentStatus.md`
- `README.md`
- 当前 Lesson 对应脚本/场景

需要复盘历史时，再读取 `Docs/Archive/` 中对应 Lesson 文件。

## 当前进度

- 当前完成：Lesson15 光源组件练习
- 下一阶段：继续学习 Lesson16 或下一 P 内容
- 当前项目环境：Unity `6000.3.10f1`，Input System `1.18.0`
- 最近提交：`study: 完成唐老狮教程 - Lesson15 光源组件练习`

## 归档索引

- [Lesson11 - Input System 与坦克控制](Archive/Lesson11-InputSystem.md)
- [Lesson12 - Screen 扩展与炮管俯仰](Archive/Lesson12-ScreenAndGunPitch.md)
- [Lesson13 - Camera 组件练习](Archive/Lesson13-Camera.md)
- [Lesson14 - 坐标转换练习](Archive/Lesson14-CoordinateConversion.md)
- [Lesson15 - 光源组件练习](Archive/Lesson15-Light.md)
- [文档结构调整记录](Archive/DocsReorganization.md)

## 最近变更

### 2026-05-30 Lesson15 光源组件练习

#### 教程/小节名称

唐老狮 Unity 教程 - Lesson15 光源组件练习

#### 本节目标

通过代码结合点光源模拟蜡烛光源效果，并通过方向光旋转模拟白天黑夜变化。

#### 已完成内容

- 新建 `Assets/Scripts/Lesson15/` 练习目录和 `Lesson15.unity` 场景。
- 使用 `Point Light` 模拟蜡烛光源。
- 通过移动点光源位置模拟蜡烛左右轻微摆动。
- 通过修改 `Light.intensity` 模拟蜡烛亮度波动。
- 使用 `Directional Light` 旋转模拟昼夜变化。
- 新增 `Assets/Materials/Gray.mat` 作为场景材质练习资源。
- 调整字段命名，将 `light` 改为更明确的 `candleLight`。
- 重新在 Inspector 中保存 `candleLight` 和 `directionalLight` 引用。

#### 做得好的地方

- 能根据题目要求把 Light 组件属性和 Transform 控制结合起来。
- 能把练习重点留在“理解光源组件”上，没有过早追求复杂昼夜系统。
- 发现字段重命名后的引用问题后，选择在 Unity Inspector 中重新拖引用并保存场景，处理方式符合当前学习阶段。

#### 当前问题

- 蜡烛摆动和亮度变化目前使用边界反向逻辑，能完成练习，但效果偏机械。
- 如果后续做正式项目，可以再考虑更自然的 `Mathf.Sin`、`Mathf.PingPong` 或噪声变化。

#### 推荐改进方向

- 当前教程阶段保持现有写法即可，重点理解 `Light` 组件和 Transform 控制。
- 后续个人项目中再优化光照过渡、环境光、天空盒和后处理联动。
- 重命名序列化字段时，继续注意 Inspector 引用是否仍然存在。

#### 下一节建议

继续学习下一 P 内容时，先明确题目要练的是组件 API、坐标转换、输入系统还是场景配置，再决定是否需要把优化留到个人项目中。

### 2026-05-28 文档结构调整

#### 教程/小节名称

项目文档结构优化

#### 本节目标

将原本持续追加的长文档改为“当前摘要 + 按 Lesson 归档”的结构，减少后续检查和总结时读取超长文档造成的上下文消耗。

#### 已完成内容

- 新增 `Docs/CurrentStatus.md` 作为默认读取的当前状态摘要。
- 新增 `Docs/Archive/` 目录。
- 将 Lesson11 到 Lesson14 的完整总结迁移到独立归档文件。
- 将 `LearningProgress.md` 改为索引和最近变更记录。
- 将 `TangLessonsNotes.md` 改为教程知识点索引。
- 更新 `README.md` 和 `AGENTS.md`，记录新的文档读取流程。

#### 做得好的地方

- 保留历史总结，不丢失学习过程。
- 默认读取文件变短，后续轻量检查会更省额度。
- 按 Lesson 归档更符合唐老狮教程的学习节奏。

#### 当前问题

- 历史内容迁移后，后续需要养成每节完成时同步更新 `CurrentStatus.md` 和对应 Archive 文件的习惯。

#### 推荐改进方向

- 后续默认只读 `CurrentStatus.md`，除非用户要求复盘历史或当前问题和历史 Lesson 强相关。
- 每次完成新 Lesson 时，新建 `Docs/Archive/LessonXX-主题.md`。

#### 下一节建议

继续学习下一 P 时，先在 `CurrentStatus.md` 更新当前 Lesson，再在完成后归档到 `Docs/Archive/`。
