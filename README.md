# UnityTeach1

## 项目简介

这是一个 Unity 学习练习项目，用于跟随唐老狮 Unity 教程完成基础知识、脚本、场景、Prefab 和输入系统等内容的练习。

## 当前学习来源

唐老狮 Unity 教程练习。

教程内容大约来自 2022 年左右，因此本项目会在学习原教程写法的同时，记录这些写法在当前 Unity 版本中的适用性，以及是否存在更推荐的新做法。

## 当前学习阶段

根据当前项目文件推断，项目已经包含 `Lesson01` 到 `Lesson11` 的练习内容，并开始接触旧输入系统和 Unity Input System 的对照练习。

当前项目环境：

- Unity：`6000.3.10f1`
- Input System：`1.18.0`

## 已完成内容

- Unity 项目基础结构
- 多个教程小节脚本目录
- 多个练习场景
- Prefab 练习资源
- 旧输入系统练习
- 新 Input System 练习
- Git 仓库初始化
- Unity 专用 `.gitignore`
- 项目级助手规则 `AGENTS.md`
- 学习记录文档目录 `Docs/`

## 项目结构

```text
Assets/
  Prefabs/             Prefab 练习资源
  Scenes/              Unity 场景
  Scripts/             唐老狮教程分节脚本
  PlayerController.*   Input System 输入配置和生成代码
Packages/              Unity 包配置
ProjectSettings/       Unity 项目设置
Docs/                  学习记录、常见错误和教程笔记
AGENTS.md              项目级助手协作规则
README.md              项目说明
```

## 学习记录入口

- [学习进度](Docs/LearningProgress.md)
- [常见错误](Docs/CommonMistakes.md)
- [唐老狮教程笔记](Docs/TangLessonsNotes.md)

## 后续计划

- 每完成一个教程小节后，追加学习记录。
- 每次代码审查后，整理做得好的地方和需要改进的问题。
- 将重复出现的 Unity 问题沉淀到 `CommonMistakes.md`。
- 对教程旧写法和当前 Unity 推荐写法做对照记录。
- 在合适的小节节点创建 Git commit。
