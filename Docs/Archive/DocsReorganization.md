# DocsReorganization

## 2026-05-28 文档结构调整

### 背景

原来的 `LearningProgress.md` 和 `TangLessonsNotes.md` 采用持续追加的方式。随着 Lesson 增多，每次检查代码、总结本节或 push 前都需要读取越来越长的 Markdown，消耗较多上下文额度。

### 调整目标

改为“最新摘要 + 按 Lesson 归档”的结构：

- 默认读取短文件，减少上下文消耗。
- 历史内容按 Lesson 查找，和唐老狮教程学习节奏一致。
- 保留完整学习记录，不丢失复盘价值。

### 调整后的结构

```text
Docs/
  CurrentStatus.md
  LearningProgress.md
  CommonMistakes.md
  TangLessonsNotes.md
  Archive/
    Lesson11-InputSystem.md
    Lesson12-ScreenAndGunPitch.md
    Lesson13-Camera.md
    Lesson14-CoordinateConversion.md
    DocsReorganization.md
```

### 新职责

- `CurrentStatus.md`：当前进度、最近完成、当前风险、默认检查入口。
- `LearningProgress.md`：进度索引和最近变更。
- `TangLessonsNotes.md`：教程知识点索引和主题入口。
- `CommonMistakes.md`：继续记录反复出现的问题。
- `Archive/`：保存每个 Lesson 的完整总结。

### 后续规则

- 轻量检查优先读取 `CurrentStatus.md`。
- 完成新 Lesson 时，新增或更新对应 `Archive/LessonXX-主题.md`。
- push 前检查 `CurrentStatus.md`、`LearningProgress.md`、`TangLessonsNotes.md`、`README.md` 是否需要同步。
