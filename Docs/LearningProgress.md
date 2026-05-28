# LearningProgress

本文件现在作为学习进度索引和最近变更记录使用。完整小节总结按 Lesson 归档到 `Docs/Archive/`。

日常检查时优先读取：

- `Docs/CurrentStatus.md`
- `README.md`
- 当前 Lesson 对应脚本/场景

需要复盘历史时，再读取 `Docs/Archive/` 中对应 Lesson 文件。

## 当前进度

- 当前完成：Lesson14 坐标转换练习
- 下一阶段：继续学习 Lesson15 或下一 P 内容
- 当前项目环境：Unity `6000.3.10f1`，Input System `1.18.0`
- 最近提交：`f705624 study: 完成唐老狮教程 - Lesson14 坐标转换练习`

## 归档索引

- [Lesson11 - Input System 与坦克控制](Archive/Lesson11-InputSystem.md)
- [Lesson12 - Screen 扩展与炮管俯仰](Archive/Lesson12-ScreenAndGunPitch.md)
- [Lesson13 - Camera 组件练习](Archive/Lesson13-Camera.md)
- [Lesson14 - 坐标转换练习](Archive/Lesson14-CoordinateConversion.md)
- [文档结构调整记录](Archive/DocsReorganization.md)

## 最近变更

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
