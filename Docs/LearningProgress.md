# LearningProgress

## 2026-05-26 初始学习记录

### 教程/小节名称

唐老狮 Unity 教程练习项目初始化记录

### 本节目标

建立长期学习记录体系，整理当前项目状态，方便之后按教程小节持续记录进度、问题和改进方向。

### 已完成内容

- 项目已配置为 Git 仓库，并绑定远程仓库 `https://github.com/CyreneAmphoreus/UnityTeach1.git`。
- 已添加 Unity 项目 `.gitignore`。
- 已建立项目级助手规则 `AGENTS.md`。
- 当前项目中可见 `Lesson01` 到 `Lesson11` 的练习脚本。
- 项目包含多个 Unity 场景、Prefab 练习资源，以及 Input System 相关配置。
- 当前 Unity 版本为 `6000.3.10f1`。
- 当前 Input System 包版本为 `1.18.0`。

### 做得好的地方

- 按课程小节拆分脚本目录，便于回看每节内容。
- 已同时保留旧输入系统和新 Input System 的练习代码，适合对比教程旧写法和当前推荐写法。
- 开始引入文档记录和 Git 管理，有利于长期复盘。

### 当前问题

- 目前学习进度主要根据项目文件推断，还需要用户在后续记录中补充每节具体标题和目标。
- `Docs` 学习记录刚建立，尚未积累常见错误和每节总结。
- 后续提交时需要注意只提交 `Assets/`、`Packages/`、`ProjectSettings/`、`Docs/`、`README.md`、`.gitignore`、`AGENTS.md` 等有效内容。

### 推荐改进方向

- 每完成一节后及时追加学习记录，不要等很多节之后再补。
- 做代码审查时，把重复出现的问题同步记录到 `CommonMistakes.md`。
- 对唐老狮教程中偏旧的 API 或习惯写法，在 `TangLessonsNotes.md` 中记录当前 Unity 版本下的推荐选择。

### 下一节建议

下次从当前正在练习的具体小节开始记录，例如 `Lesson11` 的输入系统练习，明确本节目标、实现效果、遇到的问题和下一步要验证的行为。
