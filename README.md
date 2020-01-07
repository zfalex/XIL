## XIL 
## 使用ILRuntime实现的类似XLUA功能的Unity3D下热修复BUG的解决方案

**公司项目[(初音未来:梦幻歌姬)](http://miku.qq.com)已经使用此插件上线，由腾讯运营，上线运营情况良好，插件自身目前暂未发现BUG!**  

下图为Demo截图
![Demo截图](http://192.168.11.132/swh/20200108002228.png)

**请使用Unity2019.2.17f1版本打开，其他版本问题，请自行修复报错提示！Unity3D 5.x版本以下可以使用[Unity4.7.2](https://github.com/wuxiongbin/XIL/tree/Unity4.7.2)分支~**

和XLUA一样的地方  
和XLUA原理类似，注入和XLUA基本一致。

不一样的地方  
使用C#来进行代码的热更，避免项目内lua与C#代码交叉混杂，修复BUG时，需要C#一份，lua一份。

目录以及文件说明:
Project-  
      ----Assets/XIL&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;--- 所有XIL所用到的文件  
      ----Assets/XIL/ILSource&#8194;&#8194;&#8194;&#8194;--- [ILRuntime](https://github.com/Ourpalm/ILRuntime.git)插件源文件  
      ----Assets/XIL/Scripts&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;--- 注入以及初始化代码  
      ----Assets/XIL/Auto&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;--- 自动生成注入的代码以及自动生成的委托和函数的注册(如有此目录下的脚本报错，则可以直接删除此目录，然后重新生成委托，CLR绑定以及重新注册注入类型)  
      ----Hot&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;--- 补丁源文件存放目录  
      ----Hot.sln&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;--- 补丁源文件VS解决方案  
      ----DyncDll.csproj&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;--- 补丁项目工程文件  
      ----Data/DyncDll.dll&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;--- 补丁dll文件  
      ----Data/DyncDll.pdb&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;--- 补丁dll的调试文件  
     
    
### 使用步骤以及菜单项说明:  
#### **注意：菜单项会根据是否开启热更宏而有所不同**
XIL/插件/开启&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;-- 开启热补丁宏  
XIL/插件/取消&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;-- 关闭热补丁宏  
XIL/插件/PDB开启&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;-- 加载PDB调试文件  
XIL/插件/PDB取消&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;-- 不加载PDB调试文件  
XIL/注册需要热更的类&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;-- 生成注入所需要的成员接口  
XIL/取消需要热更的类&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;-- 清除注入所需要的成员接口  
XIL/一键清除&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;-- 清除自动生成的脚本  
XIL/一键生成&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;-- 自动生成委托注册以及注入所需要的脚本  
XIL/委托自动生成&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;-- 热更当中操作C#层的委托，需要注册委托相关的类型以及转换代码                               这里可自动分析项目当中所有用到的委托，自动注册  
XIL/清除委托自动生成的脚本&#8194;&#8194;--清除委托自动生成的脚本，删除一些C#脚本，或修改，有可能引起报错，这时可以清除掉自动生成的注册脚本  
XIL/CLR绑定&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;-- 非反射的方式调用C#层的接口,可大幅度提高运行效率,一些常用的接口可考虑在GenerateCLRBinding文件当中添加需要CLR绑定的类型。  
XIL/Hotfix Inject In Editor &#8194;&#8194;&#8194;-- 编辑器下注入接口

**只需要两步即可**  
1 先开启补丁宏  
2 点击一键生成

**初始化以及资源接口**  
1 需要在项目启动或适当位置调用初始化接口:wxb.hotMgr.Init();  
2 非编辑器下，需要自己创建加载文件的接口，可参考编辑器下的资源加载类EditorResLoad。  

**生成补丁dll**  
1 打开Hot解决方案  
2 替换DyncDll工程依赖UnityEngine.dll以及UnityEngine.UI.dll的文件，在目录Hot下，默认是Unity2018.2.11f1版本的，可以替换为自己项目对应的版本  
3 编译运行DyncDll工程，编译成功，即可在Data目录下生成补丁库。

**如何添加需要热更的类型:**  
1 使用HotfixAttribute属性宏来修饰类型  
2 默认情况下所有类型都会被热更注入，如需要自己调整，可修改源文件ExportIL.cs里，FixMarkIL接口，自定义需要热更的类型

**生成静态DelegateBridge字段名称的规则**  
1. 没有同名函数，则固定使用"__Hotfix_函数名"方式  
2. 有多个同名函数，对这些同名函数进行排序，排序规则如下(可参考接口wxb.Editor.Hotfix.getDelegateName的逻辑):  
  1 参数个数少的在前  
  2 进行字符串拼接，组成key值，规则如下"返回值全名 函数名(参数类型全名1,参数类型全名2,...)"，之后通过key值比较，理论上，不同函数，key值是不会相同的    排序之后，取得对应函数在数组当中的下标来进行拼接如何，规则如下"__Hotfix_函数名_下标"的方式  为什么排序，主要是希望能够一眼看过去就知道函数对应的下标是多少，方便Hotfix，以及保证源脚本不变的情况下，每次Hotfix生成的字段名是一致的

**如何替换函数**  
一般有三种方式
1. 通过函数名直接替换hotMgr.ReplaceFunc,可参考函数HotHelloWorld.Reg
2. 通过自动生成的接口DelegateBridge对应的字段名，可直接使用hotMgr.ReplaceField，可参考函数HotHelloWorld.Reg
3. **通过添加属性来自动注册**，可参考脚本HotHelloWorld.cs与HotTemplate.cs,这里简单说明下,  要替换一个接口，要知道至少三个信息
    - 1. 替换的原类型
    - 2. 替换的接口对应的DelegateBridge字段的名字
    - 3. 热更当中，要替换的MethodInfo  
    可添加属性ReplaceType到热更的类当中，表示此类型下的接口，默认替换的类型  
	可添加属性ReplaceFunction到热更的接口当中，表示此接口需要替换哪个类型的哪个接口,可使用三种方式初始化  
	1 ReplaceFunction(System.Type type)                    替换type类型下同名的接口  
	2 ReplaceFunction()                                    替换ReplaceType类型下同名的接口  
	3 ReplaceFunction(string fieldNameOrTypeName), fieldNameOrTypeName值前缀不同，有不同的含义  
&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;a __Hotfix_开头，替换ReplaceType类型fieldName字段对应的接口  
&#8194;&#8194;&#8194;&#8194;&#8194;&#8194;b 替换类型全名为fieldNameOrTypeName下同名的接口  
	4 ReplaceFunction(System.Type type, string fieldName)  替换type类型fieldName字段对应的接口  
	5 ReplaceFunction(string type, string fieldName)  替换类型全名为type下fieldName字段对应的接口  

	一般在没有**同名函数**情况下，可使用**1，2**种方式注册，有些类型为**非公有类型**的，可通过**3,5**接口，通过类型名来注册  
	有**同名函数**情况下，就需要使用**3，4, 5**方式进行注册，可参考HotHelloWorld.cs脚本  

	**通过属性进行自动注册的，假如在类型中含有对应DelegateBridge静态字段的Hotfix变量，则会自动对此变量进行赋值，保存一些参数**  
	**在实际使用补丁方式热更时，经常遇到一些，只是需要在原有函数之前或之后添加一些代码的情况，这时，你可以通过Hotfix来执行原先代码**  
	可参考HotHelloWorld.Start的使用  
**建议使用第3种方式进行接口替换**

建议：  
最好安装下.NET Reflector，可用来反编译被注入的dll,查看源文件，可加深理解XIL的实现原理。  
项目下文件Library/ScriptAssemblies/Assembly-CSharp.dll这u3d生成的dll文件，原理上，也是修改此文件实现热更新功能,可使用.NET Reflector进行反编译查看源码  

热更下模拟MonoBehaviour组件,用法可以参考hotScripts下脚本，可以做到平时在非热更环境下开发调试，到要发版本时再转换为热更方式

**Unity5.6以下版本**，编辑器下使用的Mono库，会报错，**应该是Unity3D的Bug**。可以使用源文件来替换dll，源文件在压缩包Mono.Cecil.zip下,可解压此文件，放到在Assets/XIL/Scripts/ILHotfix/Editor/下，并删除这三个Dll(Mono.Cecil.dll, Mono.Cecil.Mdb.dll,MonoCecil.Pdb.dll)

如遇到BUG，可添加QQ群:784186449或邮件qewsfs@qq.com联系。
