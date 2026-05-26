# UnityTeach1

## 项目简介

这是一个 Unity 学习练习项目，用于跟随唐老狮 Unity 教程完成基础知识、脚本、场景、Prefab、输入系统、Transform 控制等内容的练习。

本项目不只是保存代码，也会长期记录学习过程、常见错误、教程旧写法与当前 Unity 推荐写法之间的差异。

## 当前学习来源

唐老狮 Unity 教程练习。

教程内容大约来自 2022 年左右，因此本项目会在学习原教程写法的同时，记录这些写法在当前 Unity 版本中的适用性，以及是否存在更推荐的新做法。

## 当前学习阶段

当前已完成到 `Lesson12 / Screen 分 P 扩展练习` 附近。

虽然 Screen 分 P 的教程内容和习题较少，但本项目在这一节中扩展练习了鼠标滚轮、炮管俯仰、右键摄像机观察和 Unity 欧拉角限制等内容。

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
- `Lesson11` 坦克移动、车体旋转和炮塔旋转
- `Lesson11` 新旧输入系统对照
- `Lesson12` 鼠标滚轮控制炮管上下俯仰
- `Lesson12` 炮管俯仰角度限制
- 右键按住时摄像机围绕坦克观察
- Unity 欧拉角 `0~360` 与 `-180~180` 转换理解
- Git 仓库初始化和 GitHub 推送
- Unity 专用 `.gitignore`
- 项目级助手规则 `AGENTS.md`
- 学习记录文档目录 `Docs/`
- GPT 辅助学习过程记录目录 `Gpt对话协助/`

## 项目结构

```text
Assets/
  Prefabs/             Prefab 练习资源
  Scenes/              Unity 场景
  Scripts/             唐老狮教程分节脚本
  PlayerController.*   Input System 输入配置和生成代码
Packages/              Unity 包配置
ProjectSettings/       Unity 项目设置
Docs/                  学习进度、常见错误和教程笔记
Gpt对话协助/           通过 GPT 辅助解决问题的学习记录
AGENTS.md              项目级助手协作规则
README.md              项目说明
```

## 学习记录入口

- [学习进度](Docs/LearningProgress.md)
- [常见错误](Docs/CommonMistakes.md)
- [唐老狮教程笔记](Docs/TangLessonsNotes.md)
- [GPT 辅助学习记录](Gpt对话协助/)

## 当前重点记录

- 旧输入系统仍有现实项目价值，尤其是存量项目和小型练习。
- 新 Input System 更适合结构化输入配置、多设备和可维护项目。
- 坦克的 `A/D` 更适合做车体旋转，而不是左右平移。
- `transform.Find` 适合学习层级查找，但稳定项目中更推荐 Inspector 显式引用。
- `Mathf.Clamp` 只返回限制后的值，不会自动修改 Transform。
- Unity 的 `localEulerAngles` 常以 `0~360` 表示，限制负角度前需要转换成 signed angle。

## 后续计划

- 每完成一个教程小节后，追加学习记录并同步检查 README 是否需要更新。
- 每次代码审查后，整理做得好的地方和需要改进的问题。
- 将重复出现的 Unity 问题沉淀到 `CommonMistakes.md`。
- 对教程旧写法和当前 Unity 推荐写法做对照记录。
- 继续保持新旧输入系统对照学习。
- 在合适的小节节点创建 Git commit，并在明确要求时 push 到 GitHub。
