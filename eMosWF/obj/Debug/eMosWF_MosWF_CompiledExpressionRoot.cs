namespace eMosWF {
    
    #line 29 "C:\Users\M.Chandrasegaram\Documents\testing\source\source\repos\eSSIC\eMosWF\MosWF.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\M.Chandrasegaram\Documents\testing\source\source\repos\eSSIC\eMosWF\MosWF.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 30 "C:\Users\M.Chandrasegaram\Documents\testing\source\source\repos\eSSIC\eMosWF\MosWF.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\M.Chandrasegaram\Documents\testing\source\source\repos\eSSIC\eMosWF\MosWF.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\M.Chandrasegaram\Documents\testing\source\source\repos\eSSIC\eMosWF\MosWF.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\M.Chandrasegaram\Documents\testing\source\source\repos\eSSIC\eMosWF\MosWF.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 31 "C:\Users\M.Chandrasegaram\Documents\testing\source\source\repos\eSSIC\eMosWF\MosWF.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 32 "C:\Users\M.Chandrasegaram\Documents\testing\source\source\repos\eSSIC\eMosWF\MosWF.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 33 "C:\Users\M.Chandrasegaram\Documents\testing\source\source\repos\eSSIC\eMosWF\MosWF.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\M.Chandrasegaram\Documents\testing\source\source\repos\eSSIC\eMosWF\MosWF.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class MosWF : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
        private System.Activities.Activity rootActivity;
        
        private object dataContextActivities;
        
        private bool forImplementation = true;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public string GetLanguage() {
            return "C#";
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((this.dataContextActivities == null)) {
                this.dataContextActivities = MosWF_TypedDataContext3.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new MosWF_TypedDataContext3(locations, activityContext, true);
                }
                MosWF_TypedDataContext3 refDataContext0 = ((MosWF_TypedDataContext3)(cachedCompiledDataContext[0]));
                return refDataContext0.GetLocation<int>(refDataContext0.ValueType___Expr0Get, refDataContext0.ValueType___Expr0Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new MosWF_TypedDataContext3(locations, activityContext, true);
                }
                MosWF_TypedDataContext3 refDataContext1 = ((MosWF_TypedDataContext3)(cachedCompiledDataContext[0]));
                return refDataContext1.GetLocation<int>(refDataContext1.ValueType___Expr1Get, refDataContext1.ValueType___Expr1Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new MosWF_TypedDataContext3(locations, activityContext, true);
                }
                MosWF_TypedDataContext3 refDataContext2 = ((MosWF_TypedDataContext3)(cachedCompiledDataContext[0]));
                return refDataContext2.GetLocation<int>(refDataContext2.ValueType___Expr2Get, refDataContext2.ValueType___Expr2Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new MosWF_TypedDataContext3(locations, activityContext, true);
                }
                MosWF_TypedDataContext3 refDataContext3 = ((MosWF_TypedDataContext3)(cachedCompiledDataContext[0]));
                return refDataContext3.GetLocation<int>(refDataContext3.ValueType___Expr3Get, refDataContext3.ValueType___Expr3Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new MosWF_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext4_ForReadOnly valDataContext4 = ((MosWF_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new MosWF_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext4_ForReadOnly valDataContext5 = ((MosWF_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new MosWF_TypedDataContext4(locations, activityContext, true);
                }
                MosWF_TypedDataContext4 refDataContext6 = ((MosWF_TypedDataContext4)(cachedCompiledDataContext[2]));
                return refDataContext6.GetLocation<bool>(refDataContext6.ValueType___Expr6Get, refDataContext6.ValueType___Expr6Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new MosWF_TypedDataContext4(locations, activityContext, true);
                }
                MosWF_TypedDataContext4 refDataContext7 = ((MosWF_TypedDataContext4)(cachedCompiledDataContext[2]));
                return refDataContext7.GetLocation<bool>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new MosWF_TypedDataContext4(locations, activityContext, true);
                }
                MosWF_TypedDataContext4 refDataContext8 = ((MosWF_TypedDataContext4)(cachedCompiledDataContext[2]));
                return refDataContext8.GetLocation<bool>(refDataContext8.ValueType___Expr8Get, refDataContext8.ValueType___Expr8Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new MosWF_TypedDataContext4(locations, activityContext, true);
                }
                MosWF_TypedDataContext4 refDataContext9 = ((MosWF_TypedDataContext4)(cachedCompiledDataContext[2]));
                return refDataContext9.GetLocation<bool>(refDataContext9.ValueType___Expr9Get, refDataContext9.ValueType___Expr9Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new MosWF_TypedDataContext4(locations, activityContext, true);
                }
                MosWF_TypedDataContext4 refDataContext10 = ((MosWF_TypedDataContext4)(cachedCompiledDataContext[2]));
                return refDataContext10.GetLocation<bool>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new MosWF_TypedDataContext4(locations, activityContext, true);
                }
                MosWF_TypedDataContext4 refDataContext11 = ((MosWF_TypedDataContext4)(cachedCompiledDataContext[2]));
                return refDataContext11.GetLocation<bool>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new MosWF_TypedDataContext4(locations, activityContext, true);
                }
                MosWF_TypedDataContext4 refDataContext12 = ((MosWF_TypedDataContext4)(cachedCompiledDataContext[2]));
                return refDataContext12.GetLocation<bool>(refDataContext12.ValueType___Expr12Get, refDataContext12.ValueType___Expr12Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new MosWF_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext4_ForReadOnly valDataContext13 = ((MosWF_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new MosWF_TypedDataContext4(locations, activityContext, true);
                }
                MosWF_TypedDataContext4 refDataContext14 = ((MosWF_TypedDataContext4)(cachedCompiledDataContext[2]));
                return refDataContext14.GetLocation<int>(refDataContext14.ValueType___Expr14Get, refDataContext14.ValueType___Expr14Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 15)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new MosWF_TypedDataContext4(locations, activityContext, true);
                }
                MosWF_TypedDataContext4 refDataContext15 = ((MosWF_TypedDataContext4)(cachedCompiledDataContext[2]));
                return refDataContext15.GetLocation<int>(refDataContext15.ValueType___Expr15Get, refDataContext15.ValueType___Expr15Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 16)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new MosWF_TypedDataContext4(locations, activityContext, true);
                }
                MosWF_TypedDataContext4 refDataContext16 = ((MosWF_TypedDataContext4)(cachedCompiledDataContext[2]));
                return refDataContext16.GetLocation<int>(refDataContext16.ValueType___Expr16Get, refDataContext16.ValueType___Expr16Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 17)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new MosWF_TypedDataContext4(locations, activityContext, true);
                }
                MosWF_TypedDataContext4 refDataContext17 = ((MosWF_TypedDataContext4)(cachedCompiledDataContext[2]));
                return refDataContext17.GetLocation<int>(refDataContext17.ValueType___Expr17Get, refDataContext17.ValueType___Expr17Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 18)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new MosWF_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext4_ForReadOnly valDataContext18 = ((MosWF_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext18.ValueType___Expr18Get();
            }
            if ((expressionId == 19)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new MosWF_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext5_ForReadOnly valDataContext19 = ((MosWF_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext19.ValueType___Expr19Get();
            }
            if ((expressionId == 20)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new MosWF_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext5_ForReadOnly valDataContext20 = ((MosWF_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new MosWF_TypedDataContext5(locations, activityContext, true);
                }
                MosWF_TypedDataContext5 refDataContext21 = ((MosWF_TypedDataContext5)(cachedCompiledDataContext[4]));
                return refDataContext21.GetLocation<bool>(refDataContext21.ValueType___Expr21Get, refDataContext21.ValueType___Expr21Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 22)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new MosWF_TypedDataContext5(locations, activityContext, true);
                }
                MosWF_TypedDataContext5 refDataContext22 = ((MosWF_TypedDataContext5)(cachedCompiledDataContext[4]));
                return refDataContext22.GetLocation<bool>(refDataContext22.ValueType___Expr22Get, refDataContext22.ValueType___Expr22Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 23)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new MosWF_TypedDataContext5(locations, activityContext, true);
                }
                MosWF_TypedDataContext5 refDataContext23 = ((MosWF_TypedDataContext5)(cachedCompiledDataContext[4]));
                return refDataContext23.GetLocation<bool>(refDataContext23.ValueType___Expr23Get, refDataContext23.ValueType___Expr23Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 24)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new MosWF_TypedDataContext5(locations, activityContext, true);
                }
                MosWF_TypedDataContext5 refDataContext24 = ((MosWF_TypedDataContext5)(cachedCompiledDataContext[4]));
                return refDataContext24.GetLocation<bool>(refDataContext24.ValueType___Expr24Get, refDataContext24.ValueType___Expr24Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 25)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new MosWF_TypedDataContext5(locations, activityContext, true);
                }
                MosWF_TypedDataContext5 refDataContext25 = ((MosWF_TypedDataContext5)(cachedCompiledDataContext[4]));
                return refDataContext25.GetLocation<bool>(refDataContext25.ValueType___Expr25Get, refDataContext25.ValueType___Expr25Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 26)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new MosWF_TypedDataContext5(locations, activityContext, true);
                }
                MosWF_TypedDataContext5 refDataContext26 = ((MosWF_TypedDataContext5)(cachedCompiledDataContext[4]));
                return refDataContext26.GetLocation<bool>(refDataContext26.ValueType___Expr26Get, refDataContext26.ValueType___Expr26Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 27)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new MosWF_TypedDataContext5(locations, activityContext, true);
                }
                MosWF_TypedDataContext5 refDataContext27 = ((MosWF_TypedDataContext5)(cachedCompiledDataContext[4]));
                return refDataContext27.GetLocation<bool>(refDataContext27.ValueType___Expr27Get, refDataContext27.ValueType___Expr27Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 28)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new MosWF_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext5_ForReadOnly valDataContext28 = ((MosWF_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext28.ValueType___Expr28Get();
            }
            if ((expressionId == 29)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new MosWF_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext5_ForReadOnly valDataContext29 = ((MosWF_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext29.ValueType___Expr29Get();
            }
            if ((expressionId == 30)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new MosWF_TypedDataContext5(locations, activityContext, true);
                }
                MosWF_TypedDataContext5 refDataContext30 = ((MosWF_TypedDataContext5)(cachedCompiledDataContext[4]));
                return refDataContext30.GetLocation<int>(refDataContext30.ValueType___Expr30Get, refDataContext30.ValueType___Expr30Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 31)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new MosWF_TypedDataContext5(locations, activityContext, true);
                }
                MosWF_TypedDataContext5 refDataContext31 = ((MosWF_TypedDataContext5)(cachedCompiledDataContext[4]));
                return refDataContext31.GetLocation<int>(refDataContext31.ValueType___Expr31Get, refDataContext31.ValueType___Expr31Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 32)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new MosWF_TypedDataContext5(locations, activityContext, true);
                }
                MosWF_TypedDataContext5 refDataContext32 = ((MosWF_TypedDataContext5)(cachedCompiledDataContext[4]));
                return refDataContext32.GetLocation<int>(refDataContext32.ValueType___Expr32Get, refDataContext32.ValueType___Expr32Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 33)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new MosWF_TypedDataContext5(locations, activityContext, true);
                }
                MosWF_TypedDataContext5 refDataContext33 = ((MosWF_TypedDataContext5)(cachedCompiledDataContext[4]));
                return refDataContext33.GetLocation<int>(refDataContext33.ValueType___Expr33Get, refDataContext33.ValueType___Expr33Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 34)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new MosWF_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext5_ForReadOnly valDataContext34 = ((MosWF_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext34.ValueType___Expr34Get();
            }
            if ((expressionId == 35)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new MosWF_TypedDataContext5(locations, activityContext, true);
                }
                MosWF_TypedDataContext5 refDataContext35 = ((MosWF_TypedDataContext5)(cachedCompiledDataContext[4]));
                return refDataContext35.GetLocation<int>(refDataContext35.ValueType___Expr35Get, refDataContext35.ValueType___Expr35Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 36)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new MosWF_TypedDataContext5(locations, activityContext, true);
                }
                MosWF_TypedDataContext5 refDataContext36 = ((MosWF_TypedDataContext5)(cachedCompiledDataContext[4]));
                return refDataContext36.GetLocation<int>(refDataContext36.ValueType___Expr36Get, refDataContext36.ValueType___Expr36Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 37)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new MosWF_TypedDataContext5(locations, activityContext, true);
                }
                MosWF_TypedDataContext5 refDataContext37 = ((MosWF_TypedDataContext5)(cachedCompiledDataContext[4]));
                return refDataContext37.GetLocation<int>(refDataContext37.ValueType___Expr37Get, refDataContext37.ValueType___Expr37Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 38)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new MosWF_TypedDataContext5(locations, activityContext, true);
                }
                MosWF_TypedDataContext5 refDataContext38 = ((MosWF_TypedDataContext5)(cachedCompiledDataContext[4]));
                return refDataContext38.GetLocation<int>(refDataContext38.ValueType___Expr38Get, refDataContext38.ValueType___Expr38Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 39)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new MosWF_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext5_ForReadOnly valDataContext39 = ((MosWF_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext39.ValueType___Expr39Get();
            }
            if ((expressionId == 40)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new MosWF_TypedDataContext5(locations, activityContext, true);
                }
                MosWF_TypedDataContext5 refDataContext40 = ((MosWF_TypedDataContext5)(cachedCompiledDataContext[4]));
                return refDataContext40.GetLocation<int>(refDataContext40.ValueType___Expr40Get, refDataContext40.ValueType___Expr40Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 41)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new MosWF_TypedDataContext5(locations, activityContext, true);
                }
                MosWF_TypedDataContext5 refDataContext41 = ((MosWF_TypedDataContext5)(cachedCompiledDataContext[4]));
                return refDataContext41.GetLocation<int>(refDataContext41.ValueType___Expr41Get, refDataContext41.ValueType___Expr41Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 42)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new MosWF_TypedDataContext5(locations, activityContext, true);
                }
                MosWF_TypedDataContext5 refDataContext42 = ((MosWF_TypedDataContext5)(cachedCompiledDataContext[4]));
                return refDataContext42.GetLocation<int>(refDataContext42.ValueType___Expr42Get, refDataContext42.ValueType___Expr42Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 43)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new MosWF_TypedDataContext5(locations, activityContext, true);
                }
                MosWF_TypedDataContext5 refDataContext43 = ((MosWF_TypedDataContext5)(cachedCompiledDataContext[4]));
                return refDataContext43.GetLocation<int>(refDataContext43.ValueType___Expr43Get, refDataContext43.ValueType___Expr43Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 44)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new MosWF_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext6_ForReadOnly valDataContext44 = ((MosWF_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext44.ValueType___Expr44Get();
            }
            if ((expressionId == 45)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new MosWF_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext6_ForReadOnly valDataContext45 = ((MosWF_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext45.ValueType___Expr45Get();
            }
            if ((expressionId == 46)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new MosWF_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext6_ForReadOnly valDataContext46 = ((MosWF_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext46.ValueType___Expr46Get();
            }
            if ((expressionId == 47)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new MosWF_TypedDataContext6(locations, activityContext, true);
                }
                MosWF_TypedDataContext6 refDataContext47 = ((MosWF_TypedDataContext6)(cachedCompiledDataContext[6]));
                return refDataContext47.GetLocation<bool>(refDataContext47.ValueType___Expr47Get, refDataContext47.ValueType___Expr47Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 48)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new MosWF_TypedDataContext6(locations, activityContext, true);
                }
                MosWF_TypedDataContext6 refDataContext48 = ((MosWF_TypedDataContext6)(cachedCompiledDataContext[6]));
                return refDataContext48.GetLocation<bool>(refDataContext48.ValueType___Expr48Get, refDataContext48.ValueType___Expr48Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 49)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new MosWF_TypedDataContext6(locations, activityContext, true);
                }
                MosWF_TypedDataContext6 refDataContext49 = ((MosWF_TypedDataContext6)(cachedCompiledDataContext[6]));
                return refDataContext49.GetLocation<bool>(refDataContext49.ValueType___Expr49Get, refDataContext49.ValueType___Expr49Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 50)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new MosWF_TypedDataContext6(locations, activityContext, true);
                }
                MosWF_TypedDataContext6 refDataContext50 = ((MosWF_TypedDataContext6)(cachedCompiledDataContext[6]));
                return refDataContext50.GetLocation<bool>(refDataContext50.ValueType___Expr50Get, refDataContext50.ValueType___Expr50Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 51)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new MosWF_TypedDataContext6(locations, activityContext, true);
                }
                MosWF_TypedDataContext6 refDataContext51 = ((MosWF_TypedDataContext6)(cachedCompiledDataContext[6]));
                return refDataContext51.GetLocation<bool>(refDataContext51.ValueType___Expr51Get, refDataContext51.ValueType___Expr51Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 52)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new MosWF_TypedDataContext6(locations, activityContext, true);
                }
                MosWF_TypedDataContext6 refDataContext52 = ((MosWF_TypedDataContext6)(cachedCompiledDataContext[6]));
                return refDataContext52.GetLocation<bool>(refDataContext52.ValueType___Expr52Get, refDataContext52.ValueType___Expr52Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 53)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new MosWF_TypedDataContext6(locations, activityContext, true);
                }
                MosWF_TypedDataContext6 refDataContext53 = ((MosWF_TypedDataContext6)(cachedCompiledDataContext[6]));
                return refDataContext53.GetLocation<bool>(refDataContext53.ValueType___Expr53Get, refDataContext53.ValueType___Expr53Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 54)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new MosWF_TypedDataContext6(locations, activityContext, true);
                }
                MosWF_TypedDataContext6 refDataContext54 = ((MosWF_TypedDataContext6)(cachedCompiledDataContext[6]));
                return refDataContext54.GetLocation<bool>(refDataContext54.ValueType___Expr54Get, refDataContext54.ValueType___Expr54Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 55)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new MosWF_TypedDataContext6(locations, activityContext, true);
                }
                MosWF_TypedDataContext6 refDataContext55 = ((MosWF_TypedDataContext6)(cachedCompiledDataContext[6]));
                return refDataContext55.GetLocation<bool>(refDataContext55.ValueType___Expr55Get, refDataContext55.ValueType___Expr55Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 56)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new MosWF_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext6_ForReadOnly valDataContext56 = ((MosWF_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext56.ValueType___Expr56Get();
            }
            if ((expressionId == 57)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new MosWF_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext6_ForReadOnly valDataContext57 = ((MosWF_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext57.ValueType___Expr57Get();
            }
            if ((expressionId == 58)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new MosWF_TypedDataContext6(locations, activityContext, true);
                }
                MosWF_TypedDataContext6 refDataContext58 = ((MosWF_TypedDataContext6)(cachedCompiledDataContext[6]));
                return refDataContext58.GetLocation<int>(refDataContext58.ValueType___Expr58Get, refDataContext58.ValueType___Expr58Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 59)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new MosWF_TypedDataContext6(locations, activityContext, true);
                }
                MosWF_TypedDataContext6 refDataContext59 = ((MosWF_TypedDataContext6)(cachedCompiledDataContext[6]));
                return refDataContext59.GetLocation<int>(refDataContext59.ValueType___Expr59Get, refDataContext59.ValueType___Expr59Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 60)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new MosWF_TypedDataContext6(locations, activityContext, true);
                }
                MosWF_TypedDataContext6 refDataContext60 = ((MosWF_TypedDataContext6)(cachedCompiledDataContext[6]));
                return refDataContext60.GetLocation<int>(refDataContext60.ValueType___Expr60Get, refDataContext60.ValueType___Expr60Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 61)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new MosWF_TypedDataContext6(locations, activityContext, true);
                }
                MosWF_TypedDataContext6 refDataContext61 = ((MosWF_TypedDataContext6)(cachedCompiledDataContext[6]));
                return refDataContext61.GetLocation<int>(refDataContext61.ValueType___Expr61Get, refDataContext61.ValueType___Expr61Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 62)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new MosWF_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext7_ForReadOnly valDataContext62 = ((MosWF_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[7]));
                return valDataContext62.ValueType___Expr62Get();
            }
            if ((expressionId == 63)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new MosWF_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext7_ForReadOnly valDataContext63 = ((MosWF_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[7]));
                return valDataContext63.ValueType___Expr63Get();
            }
            if ((expressionId == 64)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new MosWF_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext7_ForReadOnly valDataContext64 = ((MosWF_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[7]));
                return valDataContext64.ValueType___Expr64Get();
            }
            if ((expressionId == 65)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new MosWF_TypedDataContext7(locations, activityContext, true);
                }
                MosWF_TypedDataContext7 refDataContext65 = ((MosWF_TypedDataContext7)(cachedCompiledDataContext[8]));
                return refDataContext65.GetLocation<bool>(refDataContext65.ValueType___Expr65Get, refDataContext65.ValueType___Expr65Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 66)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new MosWF_TypedDataContext7(locations, activityContext, true);
                }
                MosWF_TypedDataContext7 refDataContext66 = ((MosWF_TypedDataContext7)(cachedCompiledDataContext[8]));
                return refDataContext66.GetLocation<bool>(refDataContext66.ValueType___Expr66Get, refDataContext66.ValueType___Expr66Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 67)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new MosWF_TypedDataContext7(locations, activityContext, true);
                }
                MosWF_TypedDataContext7 refDataContext67 = ((MosWF_TypedDataContext7)(cachedCompiledDataContext[8]));
                return refDataContext67.GetLocation<bool>(refDataContext67.ValueType___Expr67Get, refDataContext67.ValueType___Expr67Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 68)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new MosWF_TypedDataContext7(locations, activityContext, true);
                }
                MosWF_TypedDataContext7 refDataContext68 = ((MosWF_TypedDataContext7)(cachedCompiledDataContext[8]));
                return refDataContext68.GetLocation<bool>(refDataContext68.ValueType___Expr68Get, refDataContext68.ValueType___Expr68Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 69)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new MosWF_TypedDataContext7(locations, activityContext, true);
                }
                MosWF_TypedDataContext7 refDataContext69 = ((MosWF_TypedDataContext7)(cachedCompiledDataContext[8]));
                return refDataContext69.GetLocation<bool>(refDataContext69.ValueType___Expr69Get, refDataContext69.ValueType___Expr69Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 70)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new MosWF_TypedDataContext7(locations, activityContext, true);
                }
                MosWF_TypedDataContext7 refDataContext70 = ((MosWF_TypedDataContext7)(cachedCompiledDataContext[8]));
                return refDataContext70.GetLocation<bool>(refDataContext70.ValueType___Expr70Get, refDataContext70.ValueType___Expr70Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 71)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new MosWF_TypedDataContext7(locations, activityContext, true);
                }
                MosWF_TypedDataContext7 refDataContext71 = ((MosWF_TypedDataContext7)(cachedCompiledDataContext[8]));
                return refDataContext71.GetLocation<bool>(refDataContext71.ValueType___Expr71Get, refDataContext71.ValueType___Expr71Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 72)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new MosWF_TypedDataContext7(locations, activityContext, true);
                }
                MosWF_TypedDataContext7 refDataContext72 = ((MosWF_TypedDataContext7)(cachedCompiledDataContext[8]));
                return refDataContext72.GetLocation<bool>(refDataContext72.ValueType___Expr72Get, refDataContext72.ValueType___Expr72Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 73)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new MosWF_TypedDataContext7(locations, activityContext, true);
                }
                MosWF_TypedDataContext7 refDataContext73 = ((MosWF_TypedDataContext7)(cachedCompiledDataContext[8]));
                return refDataContext73.GetLocation<bool>(refDataContext73.ValueType___Expr73Get, refDataContext73.ValueType___Expr73Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 74)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new MosWF_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext7_ForReadOnly valDataContext74 = ((MosWF_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[7]));
                return valDataContext74.ValueType___Expr74Get();
            }
            if ((expressionId == 75)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new MosWF_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext7_ForReadOnly valDataContext75 = ((MosWF_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[7]));
                return valDataContext75.ValueType___Expr75Get();
            }
            if ((expressionId == 76)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new MosWF_TypedDataContext7(locations, activityContext, true);
                }
                MosWF_TypedDataContext7 refDataContext76 = ((MosWF_TypedDataContext7)(cachedCompiledDataContext[8]));
                return refDataContext76.GetLocation<int>(refDataContext76.ValueType___Expr76Get, refDataContext76.ValueType___Expr76Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 77)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new MosWF_TypedDataContext7(locations, activityContext, true);
                }
                MosWF_TypedDataContext7 refDataContext77 = ((MosWF_TypedDataContext7)(cachedCompiledDataContext[8]));
                return refDataContext77.GetLocation<int>(refDataContext77.ValueType___Expr77Get, refDataContext77.ValueType___Expr77Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 78)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new MosWF_TypedDataContext7(locations, activityContext, true);
                }
                MosWF_TypedDataContext7 refDataContext78 = ((MosWF_TypedDataContext7)(cachedCompiledDataContext[8]));
                return refDataContext78.GetLocation<int>(refDataContext78.ValueType___Expr78Get, refDataContext78.ValueType___Expr78Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 79)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new MosWF_TypedDataContext7(locations, activityContext, true);
                }
                MosWF_TypedDataContext7 refDataContext79 = ((MosWF_TypedDataContext7)(cachedCompiledDataContext[8]));
                return refDataContext79.GetLocation<int>(refDataContext79.ValueType___Expr79Get, refDataContext79.ValueType___Expr79Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 80)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new MosWF_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext7_ForReadOnly valDataContext80 = ((MosWF_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[7]));
                return valDataContext80.ValueType___Expr80Get();
            }
            if ((expressionId == 81)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new MosWF_TypedDataContext7(locations, activityContext, true);
                }
                MosWF_TypedDataContext7 refDataContext81 = ((MosWF_TypedDataContext7)(cachedCompiledDataContext[8]));
                return refDataContext81.GetLocation<int>(refDataContext81.ValueType___Expr81Get, refDataContext81.ValueType___Expr81Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 82)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new MosWF_TypedDataContext7(locations, activityContext, true);
                }
                MosWF_TypedDataContext7 refDataContext82 = ((MosWF_TypedDataContext7)(cachedCompiledDataContext[8]));
                return refDataContext82.GetLocation<int>(refDataContext82.ValueType___Expr82Get, refDataContext82.ValueType___Expr82Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 83)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new MosWF_TypedDataContext7(locations, activityContext, true);
                }
                MosWF_TypedDataContext7 refDataContext83 = ((MosWF_TypedDataContext7)(cachedCompiledDataContext[8]));
                return refDataContext83.GetLocation<int>(refDataContext83.ValueType___Expr83Get, refDataContext83.ValueType___Expr83Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 84)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new MosWF_TypedDataContext7(locations, activityContext, true);
                }
                MosWF_TypedDataContext7 refDataContext84 = ((MosWF_TypedDataContext7)(cachedCompiledDataContext[8]));
                return refDataContext84.GetLocation<int>(refDataContext84.ValueType___Expr84Get, refDataContext84.ValueType___Expr84Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 85)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new MosWF_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext8_ForReadOnly valDataContext85 = ((MosWF_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext85.ValueType___Expr85Get();
            }
            if ((expressionId == 86)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new MosWF_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext8_ForReadOnly valDataContext86 = ((MosWF_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext86.ValueType___Expr86Get();
            }
            if ((expressionId == 87)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new MosWF_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext8_ForReadOnly valDataContext87 = ((MosWF_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext87.ValueType___Expr87Get();
            }
            if ((expressionId == 88)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new MosWF_TypedDataContext8(locations, activityContext, true);
                }
                MosWF_TypedDataContext8 refDataContext88 = ((MosWF_TypedDataContext8)(cachedCompiledDataContext[10]));
                return refDataContext88.GetLocation<bool>(refDataContext88.ValueType___Expr88Get, refDataContext88.ValueType___Expr88Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 89)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new MosWF_TypedDataContext8(locations, activityContext, true);
                }
                MosWF_TypedDataContext8 refDataContext89 = ((MosWF_TypedDataContext8)(cachedCompiledDataContext[10]));
                return refDataContext89.GetLocation<bool>(refDataContext89.ValueType___Expr89Get, refDataContext89.ValueType___Expr89Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 90)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new MosWF_TypedDataContext8(locations, activityContext, true);
                }
                MosWF_TypedDataContext8 refDataContext90 = ((MosWF_TypedDataContext8)(cachedCompiledDataContext[10]));
                return refDataContext90.GetLocation<bool>(refDataContext90.ValueType___Expr90Get, refDataContext90.ValueType___Expr90Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 91)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new MosWF_TypedDataContext8(locations, activityContext, true);
                }
                MosWF_TypedDataContext8 refDataContext91 = ((MosWF_TypedDataContext8)(cachedCompiledDataContext[10]));
                return refDataContext91.GetLocation<bool>(refDataContext91.ValueType___Expr91Get, refDataContext91.ValueType___Expr91Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 92)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new MosWF_TypedDataContext8(locations, activityContext, true);
                }
                MosWF_TypedDataContext8 refDataContext92 = ((MosWF_TypedDataContext8)(cachedCompiledDataContext[10]));
                return refDataContext92.GetLocation<bool>(refDataContext92.ValueType___Expr92Get, refDataContext92.ValueType___Expr92Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 93)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new MosWF_TypedDataContext8(locations, activityContext, true);
                }
                MosWF_TypedDataContext8 refDataContext93 = ((MosWF_TypedDataContext8)(cachedCompiledDataContext[10]));
                return refDataContext93.GetLocation<bool>(refDataContext93.ValueType___Expr93Get, refDataContext93.ValueType___Expr93Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 94)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new MosWF_TypedDataContext8(locations, activityContext, true);
                }
                MosWF_TypedDataContext8 refDataContext94 = ((MosWF_TypedDataContext8)(cachedCompiledDataContext[10]));
                return refDataContext94.GetLocation<bool>(refDataContext94.ValueType___Expr94Get, refDataContext94.ValueType___Expr94Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 95)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new MosWF_TypedDataContext8(locations, activityContext, true);
                }
                MosWF_TypedDataContext8 refDataContext95 = ((MosWF_TypedDataContext8)(cachedCompiledDataContext[10]));
                return refDataContext95.GetLocation<bool>(refDataContext95.ValueType___Expr95Get, refDataContext95.ValueType___Expr95Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 96)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new MosWF_TypedDataContext8(locations, activityContext, true);
                }
                MosWF_TypedDataContext8 refDataContext96 = ((MosWF_TypedDataContext8)(cachedCompiledDataContext[10]));
                return refDataContext96.GetLocation<bool>(refDataContext96.ValueType___Expr96Get, refDataContext96.ValueType___Expr96Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 97)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new MosWF_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext8_ForReadOnly valDataContext97 = ((MosWF_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext97.ValueType___Expr97Get();
            }
            if ((expressionId == 98)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new MosWF_TypedDataContext8(locations, activityContext, true);
                }
                MosWF_TypedDataContext8 refDataContext98 = ((MosWF_TypedDataContext8)(cachedCompiledDataContext[10]));
                return refDataContext98.GetLocation<int>(refDataContext98.ValueType___Expr98Get, refDataContext98.ValueType___Expr98Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 99)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new MosWF_TypedDataContext8(locations, activityContext, true);
                }
                MosWF_TypedDataContext8 refDataContext99 = ((MosWF_TypedDataContext8)(cachedCompiledDataContext[10]));
                return refDataContext99.GetLocation<int>(refDataContext99.ValueType___Expr99Get, refDataContext99.ValueType___Expr99Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 100)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new MosWF_TypedDataContext8(locations, activityContext, true);
                }
                MosWF_TypedDataContext8 refDataContext100 = ((MosWF_TypedDataContext8)(cachedCompiledDataContext[10]));
                return refDataContext100.GetLocation<int>(refDataContext100.ValueType___Expr100Get, refDataContext100.ValueType___Expr100Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 101)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new MosWF_TypedDataContext8(locations, activityContext, true);
                }
                MosWF_TypedDataContext8 refDataContext101 = ((MosWF_TypedDataContext8)(cachedCompiledDataContext[10]));
                return refDataContext101.GetLocation<int>(refDataContext101.ValueType___Expr101Get, refDataContext101.ValueType___Expr101Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 102)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new MosWF_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext8_ForReadOnly valDataContext102 = ((MosWF_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext102.ValueType___Expr102Get();
            }
            if ((expressionId == 103)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new MosWF_TypedDataContext8(locations, activityContext, true);
                }
                MosWF_TypedDataContext8 refDataContext103 = ((MosWF_TypedDataContext8)(cachedCompiledDataContext[10]));
                return refDataContext103.GetLocation<int>(refDataContext103.ValueType___Expr103Get, refDataContext103.ValueType___Expr103Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 104)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new MosWF_TypedDataContext8(locations, activityContext, true);
                }
                MosWF_TypedDataContext8 refDataContext104 = ((MosWF_TypedDataContext8)(cachedCompiledDataContext[10]));
                return refDataContext104.GetLocation<int>(refDataContext104.ValueType___Expr104Get, refDataContext104.ValueType___Expr104Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 105)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new MosWF_TypedDataContext8(locations, activityContext, true);
                }
                MosWF_TypedDataContext8 refDataContext105 = ((MosWF_TypedDataContext8)(cachedCompiledDataContext[10]));
                return refDataContext105.GetLocation<int>(refDataContext105.ValueType___Expr105Get, refDataContext105.ValueType___Expr105Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 106)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new MosWF_TypedDataContext8(locations, activityContext, true);
                }
                MosWF_TypedDataContext8 refDataContext106 = ((MosWF_TypedDataContext8)(cachedCompiledDataContext[10]));
                return refDataContext106.GetLocation<int>(refDataContext106.ValueType___Expr106Get, refDataContext106.ValueType___Expr106Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 107)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new MosWF_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext8_ForReadOnly valDataContext107 = ((MosWF_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext107.ValueType___Expr107Get();
            }
            if ((expressionId == 108)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new MosWF_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext9_ForReadOnly valDataContext108 = ((MosWF_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext108.ValueType___Expr108Get();
            }
            if ((expressionId == 109)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new MosWF_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext9_ForReadOnly valDataContext109 = ((MosWF_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext109.ValueType___Expr109Get();
            }
            if ((expressionId == 110)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new MosWF_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext9_ForReadOnly valDataContext110 = ((MosWF_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext110.ValueType___Expr110Get();
            }
            if ((expressionId == 111)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new MosWF_TypedDataContext9(locations, activityContext, true);
                }
                MosWF_TypedDataContext9 refDataContext111 = ((MosWF_TypedDataContext9)(cachedCompiledDataContext[12]));
                return refDataContext111.GetLocation<bool>(refDataContext111.ValueType___Expr111Get, refDataContext111.ValueType___Expr111Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 112)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new MosWF_TypedDataContext9(locations, activityContext, true);
                }
                MosWF_TypedDataContext9 refDataContext112 = ((MosWF_TypedDataContext9)(cachedCompiledDataContext[12]));
                return refDataContext112.GetLocation<bool>(refDataContext112.ValueType___Expr112Get, refDataContext112.ValueType___Expr112Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 113)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new MosWF_TypedDataContext9(locations, activityContext, true);
                }
                MosWF_TypedDataContext9 refDataContext113 = ((MosWF_TypedDataContext9)(cachedCompiledDataContext[12]));
                return refDataContext113.GetLocation<bool>(refDataContext113.ValueType___Expr113Get, refDataContext113.ValueType___Expr113Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 114)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new MosWF_TypedDataContext9(locations, activityContext, true);
                }
                MosWF_TypedDataContext9 refDataContext114 = ((MosWF_TypedDataContext9)(cachedCompiledDataContext[12]));
                return refDataContext114.GetLocation<bool>(refDataContext114.ValueType___Expr114Get, refDataContext114.ValueType___Expr114Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 115)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new MosWF_TypedDataContext9(locations, activityContext, true);
                }
                MosWF_TypedDataContext9 refDataContext115 = ((MosWF_TypedDataContext9)(cachedCompiledDataContext[12]));
                return refDataContext115.GetLocation<bool>(refDataContext115.ValueType___Expr115Get, refDataContext115.ValueType___Expr115Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 116)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new MosWF_TypedDataContext9(locations, activityContext, true);
                }
                MosWF_TypedDataContext9 refDataContext116 = ((MosWF_TypedDataContext9)(cachedCompiledDataContext[12]));
                return refDataContext116.GetLocation<bool>(refDataContext116.ValueType___Expr116Get, refDataContext116.ValueType___Expr116Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 117)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new MosWF_TypedDataContext9(locations, activityContext, true);
                }
                MosWF_TypedDataContext9 refDataContext117 = ((MosWF_TypedDataContext9)(cachedCompiledDataContext[12]));
                return refDataContext117.GetLocation<bool>(refDataContext117.ValueType___Expr117Get, refDataContext117.ValueType___Expr117Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 118)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new MosWF_TypedDataContext9(locations, activityContext, true);
                }
                MosWF_TypedDataContext9 refDataContext118 = ((MosWF_TypedDataContext9)(cachedCompiledDataContext[12]));
                return refDataContext118.GetLocation<bool>(refDataContext118.ValueType___Expr118Get, refDataContext118.ValueType___Expr118Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 119)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new MosWF_TypedDataContext9(locations, activityContext, true);
                }
                MosWF_TypedDataContext9 refDataContext119 = ((MosWF_TypedDataContext9)(cachedCompiledDataContext[12]));
                return refDataContext119.GetLocation<bool>(refDataContext119.ValueType___Expr119Get, refDataContext119.ValueType___Expr119Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 120)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new MosWF_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext9_ForReadOnly valDataContext120 = ((MosWF_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext120.ValueType___Expr120Get();
            }
            if ((expressionId == 121)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new MosWF_TypedDataContext9(locations, activityContext, true);
                }
                MosWF_TypedDataContext9 refDataContext121 = ((MosWF_TypedDataContext9)(cachedCompiledDataContext[12]));
                return refDataContext121.GetLocation<int>(refDataContext121.ValueType___Expr121Get, refDataContext121.ValueType___Expr121Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 122)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new MosWF_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext9_ForReadOnly valDataContext122 = ((MosWF_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext122.ValueType___Expr122Get();
            }
            if ((expressionId == 123)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new MosWF_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext9_ForReadOnly valDataContext123 = ((MosWF_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext123.ValueType___Expr123Get();
            }
            if ((expressionId == 124)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new MosWF_TypedDataContext9(locations, activityContext, true);
                }
                MosWF_TypedDataContext9 refDataContext124 = ((MosWF_TypedDataContext9)(cachedCompiledDataContext[12]));
                return refDataContext124.GetLocation<int>(refDataContext124.ValueType___Expr124Get, refDataContext124.ValueType___Expr124Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 125)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new MosWF_TypedDataContext9(locations, activityContext, true);
                }
                MosWF_TypedDataContext9 refDataContext125 = ((MosWF_TypedDataContext9)(cachedCompiledDataContext[12]));
                return refDataContext125.GetLocation<int>(refDataContext125.ValueType___Expr125Get, refDataContext125.ValueType___Expr125Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 126)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new MosWF_TypedDataContext9(locations, activityContext, true);
                }
                MosWF_TypedDataContext9 refDataContext126 = ((MosWF_TypedDataContext9)(cachedCompiledDataContext[12]));
                return refDataContext126.GetLocation<int>(refDataContext126.ValueType___Expr126Get, refDataContext126.ValueType___Expr126Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 127)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new MosWF_TypedDataContext9(locations, activityContext, true);
                }
                MosWF_TypedDataContext9 refDataContext127 = ((MosWF_TypedDataContext9)(cachedCompiledDataContext[12]));
                return refDataContext127.GetLocation<int>(refDataContext127.ValueType___Expr127Get, refDataContext127.ValueType___Expr127Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 128)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new MosWF_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext9_ForReadOnly valDataContext128 = ((MosWF_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext128.ValueType___Expr128Get();
            }
            if ((expressionId == 129)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new MosWF_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext9_ForReadOnly valDataContext129 = ((MosWF_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext129.ValueType___Expr129Get();
            }
            if ((expressionId == 130)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new MosWF_TypedDataContext9(locations, activityContext, true);
                }
                MosWF_TypedDataContext9 refDataContext130 = ((MosWF_TypedDataContext9)(cachedCompiledDataContext[12]));
                return refDataContext130.GetLocation<int>(refDataContext130.ValueType___Expr130Get, refDataContext130.ValueType___Expr130Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 131)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new MosWF_TypedDataContext9(locations, activityContext, true);
                }
                MosWF_TypedDataContext9 refDataContext131 = ((MosWF_TypedDataContext9)(cachedCompiledDataContext[12]));
                return refDataContext131.GetLocation<int>(refDataContext131.ValueType___Expr131Get, refDataContext131.ValueType___Expr131Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 132)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new MosWF_TypedDataContext9(locations, activityContext, true);
                }
                MosWF_TypedDataContext9 refDataContext132 = ((MosWF_TypedDataContext9)(cachedCompiledDataContext[12]));
                return refDataContext132.GetLocation<int>(refDataContext132.ValueType___Expr132Get, refDataContext132.ValueType___Expr132Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 133)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new MosWF_TypedDataContext9(locations, activityContext, true);
                }
                MosWF_TypedDataContext9 refDataContext133 = ((MosWF_TypedDataContext9)(cachedCompiledDataContext[12]));
                return refDataContext133.GetLocation<int>(refDataContext133.ValueType___Expr133Get, refDataContext133.ValueType___Expr133Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 134)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new MosWF_TypedDataContext9(locations, activityContext, true);
                }
                MosWF_TypedDataContext9 refDataContext134 = ((MosWF_TypedDataContext9)(cachedCompiledDataContext[12]));
                return refDataContext134.GetLocation<int>(refDataContext134.ValueType___Expr134Get, refDataContext134.ValueType___Expr134Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 135)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new MosWF_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext9_ForReadOnly valDataContext135 = ((MosWF_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext135.ValueType___Expr135Get();
            }
            if ((expressionId == 136)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new MosWF_TypedDataContext9(locations, activityContext, true);
                }
                MosWF_TypedDataContext9 refDataContext136 = ((MosWF_TypedDataContext9)(cachedCompiledDataContext[12]));
                return refDataContext136.GetLocation<int>(refDataContext136.ValueType___Expr136Get, refDataContext136.ValueType___Expr136Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 137)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[13] == null)) {
                    cachedCompiledDataContext[13] = new MosWF_TypedDataContext10_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext10_ForReadOnly valDataContext137 = ((MosWF_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[13]));
                return valDataContext137.ValueType___Expr137Get();
            }
            if ((expressionId == 138)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[13] == null)) {
                    cachedCompiledDataContext[13] = new MosWF_TypedDataContext10_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext10_ForReadOnly valDataContext138 = ((MosWF_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[13]));
                return valDataContext138.ValueType___Expr138Get();
            }
            if ((expressionId == 139)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext10.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[14] == null)) {
                    cachedCompiledDataContext[14] = new MosWF_TypedDataContext10(locations, activityContext, true);
                }
                MosWF_TypedDataContext10 refDataContext139 = ((MosWF_TypedDataContext10)(cachedCompiledDataContext[14]));
                return refDataContext139.GetLocation<bool>(refDataContext139.ValueType___Expr139Get, refDataContext139.ValueType___Expr139Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 140)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext10.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[14] == null)) {
                    cachedCompiledDataContext[14] = new MosWF_TypedDataContext10(locations, activityContext, true);
                }
                MosWF_TypedDataContext10 refDataContext140 = ((MosWF_TypedDataContext10)(cachedCompiledDataContext[14]));
                return refDataContext140.GetLocation<bool>(refDataContext140.ValueType___Expr140Get, refDataContext140.ValueType___Expr140Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 141)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext10.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[14] == null)) {
                    cachedCompiledDataContext[14] = new MosWF_TypedDataContext10(locations, activityContext, true);
                }
                MosWF_TypedDataContext10 refDataContext141 = ((MosWF_TypedDataContext10)(cachedCompiledDataContext[14]));
                return refDataContext141.GetLocation<bool>(refDataContext141.ValueType___Expr141Get, refDataContext141.ValueType___Expr141Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 142)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext10.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[14] == null)) {
                    cachedCompiledDataContext[14] = new MosWF_TypedDataContext10(locations, activityContext, true);
                }
                MosWF_TypedDataContext10 refDataContext142 = ((MosWF_TypedDataContext10)(cachedCompiledDataContext[14]));
                return refDataContext142.GetLocation<bool>(refDataContext142.ValueType___Expr142Get, refDataContext142.ValueType___Expr142Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 143)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext10.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[14] == null)) {
                    cachedCompiledDataContext[14] = new MosWF_TypedDataContext10(locations, activityContext, true);
                }
                MosWF_TypedDataContext10 refDataContext143 = ((MosWF_TypedDataContext10)(cachedCompiledDataContext[14]));
                return refDataContext143.GetLocation<bool>(refDataContext143.ValueType___Expr143Get, refDataContext143.ValueType___Expr143Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 144)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext10.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[14] == null)) {
                    cachedCompiledDataContext[14] = new MosWF_TypedDataContext10(locations, activityContext, true);
                }
                MosWF_TypedDataContext10 refDataContext144 = ((MosWF_TypedDataContext10)(cachedCompiledDataContext[14]));
                return refDataContext144.GetLocation<bool>(refDataContext144.ValueType___Expr144Get, refDataContext144.ValueType___Expr144Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 145)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext10.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[14] == null)) {
                    cachedCompiledDataContext[14] = new MosWF_TypedDataContext10(locations, activityContext, true);
                }
                MosWF_TypedDataContext10 refDataContext145 = ((MosWF_TypedDataContext10)(cachedCompiledDataContext[14]));
                return refDataContext145.GetLocation<bool>(refDataContext145.ValueType___Expr145Get, refDataContext145.ValueType___Expr145Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 146)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[13] == null)) {
                    cachedCompiledDataContext[13] = new MosWF_TypedDataContext10_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext10_ForReadOnly valDataContext146 = ((MosWF_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[13]));
                return valDataContext146.ValueType___Expr146Get();
            }
            if ((expressionId == 147)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext10.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[14] == null)) {
                    cachedCompiledDataContext[14] = new MosWF_TypedDataContext10(locations, activityContext, true);
                }
                MosWF_TypedDataContext10 refDataContext147 = ((MosWF_TypedDataContext10)(cachedCompiledDataContext[14]));
                return refDataContext147.GetLocation<int>(refDataContext147.ValueType___Expr147Get, refDataContext147.ValueType___Expr147Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 148)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext10.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[14] == null)) {
                    cachedCompiledDataContext[14] = new MosWF_TypedDataContext10(locations, activityContext, true);
                }
                MosWF_TypedDataContext10 refDataContext148 = ((MosWF_TypedDataContext10)(cachedCompiledDataContext[14]));
                return refDataContext148.GetLocation<int>(refDataContext148.ValueType___Expr148Get, refDataContext148.ValueType___Expr148Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 149)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext10.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[14] == null)) {
                    cachedCompiledDataContext[14] = new MosWF_TypedDataContext10(locations, activityContext, true);
                }
                MosWF_TypedDataContext10 refDataContext149 = ((MosWF_TypedDataContext10)(cachedCompiledDataContext[14]));
                return refDataContext149.GetLocation<int>(refDataContext149.ValueType___Expr149Get, refDataContext149.ValueType___Expr149Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 150)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext10.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[14] == null)) {
                    cachedCompiledDataContext[14] = new MosWF_TypedDataContext10(locations, activityContext, true);
                }
                MosWF_TypedDataContext10 refDataContext150 = ((MosWF_TypedDataContext10)(cachedCompiledDataContext[14]));
                return refDataContext150.GetLocation<int>(refDataContext150.ValueType___Expr150Get, refDataContext150.ValueType___Expr150Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 151)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[13] == null)) {
                    cachedCompiledDataContext[13] = new MosWF_TypedDataContext10_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext10_ForReadOnly valDataContext151 = ((MosWF_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[13]));
                return valDataContext151.ValueType___Expr151Get();
            }
            if ((expressionId == 152)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext11_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[15] == null)) {
                    cachedCompiledDataContext[15] = new MosWF_TypedDataContext11_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext11_ForReadOnly valDataContext152 = ((MosWF_TypedDataContext11_ForReadOnly)(cachedCompiledDataContext[15]));
                return valDataContext152.ValueType___Expr152Get();
            }
            if ((expressionId == 153)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext11_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[15] == null)) {
                    cachedCompiledDataContext[15] = new MosWF_TypedDataContext11_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext11_ForReadOnly valDataContext153 = ((MosWF_TypedDataContext11_ForReadOnly)(cachedCompiledDataContext[15]));
                return valDataContext153.ValueType___Expr153Get();
            }
            if ((expressionId == 154)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext11.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new MosWF_TypedDataContext11(locations, activityContext, true);
                }
                MosWF_TypedDataContext11 refDataContext154 = ((MosWF_TypedDataContext11)(cachedCompiledDataContext[16]));
                return refDataContext154.GetLocation<bool>(refDataContext154.ValueType___Expr154Get, refDataContext154.ValueType___Expr154Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 155)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext11.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new MosWF_TypedDataContext11(locations, activityContext, true);
                }
                MosWF_TypedDataContext11 refDataContext155 = ((MosWF_TypedDataContext11)(cachedCompiledDataContext[16]));
                return refDataContext155.GetLocation<bool>(refDataContext155.ValueType___Expr155Get, refDataContext155.ValueType___Expr155Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 156)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext11.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new MosWF_TypedDataContext11(locations, activityContext, true);
                }
                MosWF_TypedDataContext11 refDataContext156 = ((MosWF_TypedDataContext11)(cachedCompiledDataContext[16]));
                return refDataContext156.GetLocation<bool>(refDataContext156.ValueType___Expr156Get, refDataContext156.ValueType___Expr156Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 157)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext11.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new MosWF_TypedDataContext11(locations, activityContext, true);
                }
                MosWF_TypedDataContext11 refDataContext157 = ((MosWF_TypedDataContext11)(cachedCompiledDataContext[16]));
                return refDataContext157.GetLocation<bool>(refDataContext157.ValueType___Expr157Get, refDataContext157.ValueType___Expr157Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 158)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext11.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new MosWF_TypedDataContext11(locations, activityContext, true);
                }
                MosWF_TypedDataContext11 refDataContext158 = ((MosWF_TypedDataContext11)(cachedCompiledDataContext[16]));
                return refDataContext158.GetLocation<bool>(refDataContext158.ValueType___Expr158Get, refDataContext158.ValueType___Expr158Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 159)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext11.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new MosWF_TypedDataContext11(locations, activityContext, true);
                }
                MosWF_TypedDataContext11 refDataContext159 = ((MosWF_TypedDataContext11)(cachedCompiledDataContext[16]));
                return refDataContext159.GetLocation<bool>(refDataContext159.ValueType___Expr159Get, refDataContext159.ValueType___Expr159Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 160)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext11.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new MosWF_TypedDataContext11(locations, activityContext, true);
                }
                MosWF_TypedDataContext11 refDataContext160 = ((MosWF_TypedDataContext11)(cachedCompiledDataContext[16]));
                return refDataContext160.GetLocation<bool>(refDataContext160.ValueType___Expr160Get, refDataContext160.ValueType___Expr160Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 161)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext11_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[15] == null)) {
                    cachedCompiledDataContext[15] = new MosWF_TypedDataContext11_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext11_ForReadOnly valDataContext161 = ((MosWF_TypedDataContext11_ForReadOnly)(cachedCompiledDataContext[15]));
                return valDataContext161.ValueType___Expr161Get();
            }
            if ((expressionId == 162)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext11.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new MosWF_TypedDataContext11(locations, activityContext, true);
                }
                MosWF_TypedDataContext11 refDataContext162 = ((MosWF_TypedDataContext11)(cachedCompiledDataContext[16]));
                return refDataContext162.GetLocation<int>(refDataContext162.ValueType___Expr162Get, refDataContext162.ValueType___Expr162Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 163)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext11.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new MosWF_TypedDataContext11(locations, activityContext, true);
                }
                MosWF_TypedDataContext11 refDataContext163 = ((MosWF_TypedDataContext11)(cachedCompiledDataContext[16]));
                return refDataContext163.GetLocation<int>(refDataContext163.ValueType___Expr163Get, refDataContext163.ValueType___Expr163Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 164)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext11.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new MosWF_TypedDataContext11(locations, activityContext, true);
                }
                MosWF_TypedDataContext11 refDataContext164 = ((MosWF_TypedDataContext11)(cachedCompiledDataContext[16]));
                return refDataContext164.GetLocation<int>(refDataContext164.ValueType___Expr164Get, refDataContext164.ValueType___Expr164Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 165)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext11.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new MosWF_TypedDataContext11(locations, activityContext, true);
                }
                MosWF_TypedDataContext11 refDataContext165 = ((MosWF_TypedDataContext11)(cachedCompiledDataContext[16]));
                return refDataContext165.GetLocation<int>(refDataContext165.ValueType___Expr165Get, refDataContext165.ValueType___Expr165Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 166)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext11_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[15] == null)) {
                    cachedCompiledDataContext[15] = new MosWF_TypedDataContext11_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext11_ForReadOnly valDataContext166 = ((MosWF_TypedDataContext11_ForReadOnly)(cachedCompiledDataContext[15]));
                return valDataContext166.ValueType___Expr166Get();
            }
            if ((expressionId == 167)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext12_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[17] == null)) {
                    cachedCompiledDataContext[17] = new MosWF_TypedDataContext12_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext12_ForReadOnly valDataContext167 = ((MosWF_TypedDataContext12_ForReadOnly)(cachedCompiledDataContext[17]));
                return valDataContext167.ValueType___Expr167Get();
            }
            if ((expressionId == 168)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext12_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[17] == null)) {
                    cachedCompiledDataContext[17] = new MosWF_TypedDataContext12_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext12_ForReadOnly valDataContext168 = ((MosWF_TypedDataContext12_ForReadOnly)(cachedCompiledDataContext[17]));
                return valDataContext168.ValueType___Expr168Get();
            }
            if ((expressionId == 169)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[18] == null)) {
                    cachedCompiledDataContext[18] = new MosWF_TypedDataContext12(locations, activityContext, true);
                }
                MosWF_TypedDataContext12 refDataContext169 = ((MosWF_TypedDataContext12)(cachedCompiledDataContext[18]));
                return refDataContext169.GetLocation<int>(refDataContext169.ValueType___Expr169Get, refDataContext169.ValueType___Expr169Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 170)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[18] == null)) {
                    cachedCompiledDataContext[18] = new MosWF_TypedDataContext12(locations, activityContext, true);
                }
                MosWF_TypedDataContext12 refDataContext170 = ((MosWF_TypedDataContext12)(cachedCompiledDataContext[18]));
                return refDataContext170.GetLocation<int>(refDataContext170.ValueType___Expr170Get, refDataContext170.ValueType___Expr170Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 171)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[18] == null)) {
                    cachedCompiledDataContext[18] = new MosWF_TypedDataContext12(locations, activityContext, true);
                }
                MosWF_TypedDataContext12 refDataContext171 = ((MosWF_TypedDataContext12)(cachedCompiledDataContext[18]));
                return refDataContext171.GetLocation<int>(refDataContext171.ValueType___Expr171Get, refDataContext171.ValueType___Expr171Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 172)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[18] == null)) {
                    cachedCompiledDataContext[18] = new MosWF_TypedDataContext12(locations, activityContext, true);
                }
                MosWF_TypedDataContext12 refDataContext172 = ((MosWF_TypedDataContext12)(cachedCompiledDataContext[18]));
                return refDataContext172.GetLocation<int>(refDataContext172.ValueType___Expr172Get, refDataContext172.ValueType___Expr172Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 173)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext12_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[17] == null)) {
                    cachedCompiledDataContext[17] = new MosWF_TypedDataContext12_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext12_ForReadOnly valDataContext173 = ((MosWF_TypedDataContext12_ForReadOnly)(cachedCompiledDataContext[17]));
                return valDataContext173.ValueType___Expr173Get();
            }
            if ((expressionId == 174)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[18] == null)) {
                    cachedCompiledDataContext[18] = new MosWF_TypedDataContext12(locations, activityContext, true);
                }
                MosWF_TypedDataContext12 refDataContext174 = ((MosWF_TypedDataContext12)(cachedCompiledDataContext[18]));
                return refDataContext174.GetLocation<int>(refDataContext174.ValueType___Expr174Get, refDataContext174.ValueType___Expr174Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 175)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[18] == null)) {
                    cachedCompiledDataContext[18] = new MosWF_TypedDataContext12(locations, activityContext, true);
                }
                MosWF_TypedDataContext12 refDataContext175 = ((MosWF_TypedDataContext12)(cachedCompiledDataContext[18]));
                return refDataContext175.GetLocation<int>(refDataContext175.ValueType___Expr175Get, refDataContext175.ValueType___Expr175Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 176)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[18] == null)) {
                    cachedCompiledDataContext[18] = new MosWF_TypedDataContext12(locations, activityContext, true);
                }
                MosWF_TypedDataContext12 refDataContext176 = ((MosWF_TypedDataContext12)(cachedCompiledDataContext[18]));
                return refDataContext176.GetLocation<int>(refDataContext176.ValueType___Expr176Get, refDataContext176.ValueType___Expr176Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 177)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[18] == null)) {
                    cachedCompiledDataContext[18] = new MosWF_TypedDataContext12(locations, activityContext, true);
                }
                MosWF_TypedDataContext12 refDataContext177 = ((MosWF_TypedDataContext12)(cachedCompiledDataContext[18]));
                return refDataContext177.GetLocation<int>(refDataContext177.ValueType___Expr177Get, refDataContext177.ValueType___Expr177Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 178)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext12_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[17] == null)) {
                    cachedCompiledDataContext[17] = new MosWF_TypedDataContext12_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext12_ForReadOnly valDataContext178 = ((MosWF_TypedDataContext12_ForReadOnly)(cachedCompiledDataContext[17]));
                return valDataContext178.ValueType___Expr178Get();
            }
            if ((expressionId == 179)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext12_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[17] == null)) {
                    cachedCompiledDataContext[17] = new MosWF_TypedDataContext12_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext12_ForReadOnly valDataContext179 = ((MosWF_TypedDataContext12_ForReadOnly)(cachedCompiledDataContext[17]));
                return valDataContext179.ValueType___Expr179Get();
            }
            if ((expressionId == 180)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext13_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[19] == null)) {
                    cachedCompiledDataContext[19] = new MosWF_TypedDataContext13_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext13_ForReadOnly valDataContext180 = ((MosWF_TypedDataContext13_ForReadOnly)(cachedCompiledDataContext[19]));
                return valDataContext180.ValueType___Expr180Get();
            }
            if ((expressionId == 181)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext13.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[20] == null)) {
                    cachedCompiledDataContext[20] = new MosWF_TypedDataContext13(locations, activityContext, true);
                }
                MosWF_TypedDataContext13 refDataContext181 = ((MosWF_TypedDataContext13)(cachedCompiledDataContext[20]));
                return refDataContext181.GetLocation<int>(refDataContext181.ValueType___Expr181Get, refDataContext181.ValueType___Expr181Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 182)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext13_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[19] == null)) {
                    cachedCompiledDataContext[19] = new MosWF_TypedDataContext13_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext13_ForReadOnly valDataContext182 = ((MosWF_TypedDataContext13_ForReadOnly)(cachedCompiledDataContext[19]));
                return valDataContext182.ValueType___Expr182Get();
            }
            if ((expressionId == 183)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext13.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[20] == null)) {
                    cachedCompiledDataContext[20] = new MosWF_TypedDataContext13(locations, activityContext, true);
                }
                MosWF_TypedDataContext13 refDataContext183 = ((MosWF_TypedDataContext13)(cachedCompiledDataContext[20]));
                return refDataContext183.GetLocation<int>(refDataContext183.ValueType___Expr183Get, refDataContext183.ValueType___Expr183Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 184)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext13_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[19] == null)) {
                    cachedCompiledDataContext[19] = new MosWF_TypedDataContext13_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext13_ForReadOnly valDataContext184 = ((MosWF_TypedDataContext13_ForReadOnly)(cachedCompiledDataContext[19]));
                return valDataContext184.ValueType___Expr184Get();
            }
            if ((expressionId == 185)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext13.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[20] == null)) {
                    cachedCompiledDataContext[20] = new MosWF_TypedDataContext13(locations, activityContext, true);
                }
                MosWF_TypedDataContext13 refDataContext185 = ((MosWF_TypedDataContext13)(cachedCompiledDataContext[20]));
                return refDataContext185.GetLocation<int>(refDataContext185.ValueType___Expr185Get, refDataContext185.ValueType___Expr185Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 186)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext13_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[19] == null)) {
                    cachedCompiledDataContext[19] = new MosWF_TypedDataContext13_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext13_ForReadOnly valDataContext186 = ((MosWF_TypedDataContext13_ForReadOnly)(cachedCompiledDataContext[19]));
                return valDataContext186.ValueType___Expr186Get();
            }
            if ((expressionId == 187)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext13.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[20] == null)) {
                    cachedCompiledDataContext[20] = new MosWF_TypedDataContext13(locations, activityContext, true);
                }
                MosWF_TypedDataContext13 refDataContext187 = ((MosWF_TypedDataContext13)(cachedCompiledDataContext[20]));
                return refDataContext187.GetLocation<bool>(refDataContext187.ValueType___Expr187Get, refDataContext187.ValueType___Expr187Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 188)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext13_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[19] == null)) {
                    cachedCompiledDataContext[19] = new MosWF_TypedDataContext13_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext13_ForReadOnly valDataContext188 = ((MosWF_TypedDataContext13_ForReadOnly)(cachedCompiledDataContext[19]));
                return valDataContext188.ValueType___Expr188Get();
            }
            if ((expressionId == 189)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext13.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[20] == null)) {
                    cachedCompiledDataContext[20] = new MosWF_TypedDataContext13(locations, activityContext, true);
                }
                MosWF_TypedDataContext13 refDataContext189 = ((MosWF_TypedDataContext13)(cachedCompiledDataContext[20]));
                return refDataContext189.GetLocation<bool>(refDataContext189.ValueType___Expr189Get, refDataContext189.ValueType___Expr189Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 190)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext13_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[19] == null)) {
                    cachedCompiledDataContext[19] = new MosWF_TypedDataContext13_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext13_ForReadOnly valDataContext190 = ((MosWF_TypedDataContext13_ForReadOnly)(cachedCompiledDataContext[19]));
                return valDataContext190.ValueType___Expr190Get();
            }
            if ((expressionId == 191)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext13.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[20] == null)) {
                    cachedCompiledDataContext[20] = new MosWF_TypedDataContext13(locations, activityContext, true);
                }
                MosWF_TypedDataContext13 refDataContext191 = ((MosWF_TypedDataContext13)(cachedCompiledDataContext[20]));
                return refDataContext191.GetLocation<int>(refDataContext191.ValueType___Expr191Get, refDataContext191.ValueType___Expr191Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 192)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[21] == null)) {
                    cachedCompiledDataContext[21] = new MosWF_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext14_ForReadOnly valDataContext192 = ((MosWF_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[21]));
                return valDataContext192.ValueType___Expr192Get();
            }
            if ((expressionId == 193)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[21] == null)) {
                    cachedCompiledDataContext[21] = new MosWF_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext14_ForReadOnly valDataContext193 = ((MosWF_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[21]));
                return valDataContext193.ValueType___Expr193Get();
            }
            if ((expressionId == 194)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[21] == null)) {
                    cachedCompiledDataContext[21] = new MosWF_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext14_ForReadOnly valDataContext194 = ((MosWF_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[21]));
                return valDataContext194.ValueType___Expr194Get();
            }
            if ((expressionId == 195)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext14.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[22] == null)) {
                    cachedCompiledDataContext[22] = new MosWF_TypedDataContext14(locations, activityContext, true);
                }
                MosWF_TypedDataContext14 refDataContext195 = ((MosWF_TypedDataContext14)(cachedCompiledDataContext[22]));
                return refDataContext195.GetLocation<bool>(refDataContext195.ValueType___Expr195Get, refDataContext195.ValueType___Expr195Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 196)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext14.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[22] == null)) {
                    cachedCompiledDataContext[22] = new MosWF_TypedDataContext14(locations, activityContext, true);
                }
                MosWF_TypedDataContext14 refDataContext196 = ((MosWF_TypedDataContext14)(cachedCompiledDataContext[22]));
                return refDataContext196.GetLocation<bool>(refDataContext196.ValueType___Expr196Get, refDataContext196.ValueType___Expr196Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 197)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext14.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[22] == null)) {
                    cachedCompiledDataContext[22] = new MosWF_TypedDataContext14(locations, activityContext, true);
                }
                MosWF_TypedDataContext14 refDataContext197 = ((MosWF_TypedDataContext14)(cachedCompiledDataContext[22]));
                return refDataContext197.GetLocation<bool>(refDataContext197.ValueType___Expr197Get, refDataContext197.ValueType___Expr197Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 198)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext14.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[22] == null)) {
                    cachedCompiledDataContext[22] = new MosWF_TypedDataContext14(locations, activityContext, true);
                }
                MosWF_TypedDataContext14 refDataContext198 = ((MosWF_TypedDataContext14)(cachedCompiledDataContext[22]));
                return refDataContext198.GetLocation<bool>(refDataContext198.ValueType___Expr198Get, refDataContext198.ValueType___Expr198Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 199)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[21] == null)) {
                    cachedCompiledDataContext[21] = new MosWF_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext14_ForReadOnly valDataContext199 = ((MosWF_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[21]));
                return valDataContext199.ValueType___Expr199Get();
            }
            if ((expressionId == 200)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext14.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[22] == null)) {
                    cachedCompiledDataContext[22] = new MosWF_TypedDataContext14(locations, activityContext, true);
                }
                MosWF_TypedDataContext14 refDataContext200 = ((MosWF_TypedDataContext14)(cachedCompiledDataContext[22]));
                return refDataContext200.GetLocation<int>(refDataContext200.ValueType___Expr200Get, refDataContext200.ValueType___Expr200Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 201)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext14.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[22] == null)) {
                    cachedCompiledDataContext[22] = new MosWF_TypedDataContext14(locations, activityContext, true);
                }
                MosWF_TypedDataContext14 refDataContext201 = ((MosWF_TypedDataContext14)(cachedCompiledDataContext[22]));
                return refDataContext201.GetLocation<bool>(refDataContext201.ValueType___Expr201Get, refDataContext201.ValueType___Expr201Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 202)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext14.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[22] == null)) {
                    cachedCompiledDataContext[22] = new MosWF_TypedDataContext14(locations, activityContext, true);
                }
                MosWF_TypedDataContext14 refDataContext202 = ((MosWF_TypedDataContext14)(cachedCompiledDataContext[22]));
                return refDataContext202.GetLocation<bool>(refDataContext202.ValueType___Expr202Get, refDataContext202.ValueType___Expr202Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 203)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext14.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[22] == null)) {
                    cachedCompiledDataContext[22] = new MosWF_TypedDataContext14(locations, activityContext, true);
                }
                MosWF_TypedDataContext14 refDataContext203 = ((MosWF_TypedDataContext14)(cachedCompiledDataContext[22]));
                return refDataContext203.GetLocation<bool>(refDataContext203.ValueType___Expr203Get, refDataContext203.ValueType___Expr203Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 204)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext14.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[22] == null)) {
                    cachedCompiledDataContext[22] = new MosWF_TypedDataContext14(locations, activityContext, true);
                }
                MosWF_TypedDataContext14 refDataContext204 = ((MosWF_TypedDataContext14)(cachedCompiledDataContext[22]));
                return refDataContext204.GetLocation<bool>(refDataContext204.ValueType___Expr204Get, refDataContext204.ValueType___Expr204Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 205)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext14.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[22] == null)) {
                    cachedCompiledDataContext[22] = new MosWF_TypedDataContext14(locations, activityContext, true);
                }
                MosWF_TypedDataContext14 refDataContext205 = ((MosWF_TypedDataContext14)(cachedCompiledDataContext[22]));
                return refDataContext205.GetLocation<bool>(refDataContext205.ValueType___Expr205Get, refDataContext205.ValueType___Expr205Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 206)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[21] == null)) {
                    cachedCompiledDataContext[21] = new MosWF_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext14_ForReadOnly valDataContext206 = ((MosWF_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[21]));
                return valDataContext206.ValueType___Expr206Get();
            }
            if ((expressionId == 207)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext14.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[22] == null)) {
                    cachedCompiledDataContext[22] = new MosWF_TypedDataContext14(locations, activityContext, true);
                }
                MosWF_TypedDataContext14 refDataContext207 = ((MosWF_TypedDataContext14)(cachedCompiledDataContext[22]));
                return refDataContext207.GetLocation<int>(refDataContext207.ValueType___Expr207Get, refDataContext207.ValueType___Expr207Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 208)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext14.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[22] == null)) {
                    cachedCompiledDataContext[22] = new MosWF_TypedDataContext14(locations, activityContext, true);
                }
                MosWF_TypedDataContext14 refDataContext208 = ((MosWF_TypedDataContext14)(cachedCompiledDataContext[22]));
                return refDataContext208.GetLocation<int>(refDataContext208.ValueType___Expr208Get, refDataContext208.ValueType___Expr208Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 209)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext14.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[22] == null)) {
                    cachedCompiledDataContext[22] = new MosWF_TypedDataContext14(locations, activityContext, true);
                }
                MosWF_TypedDataContext14 refDataContext209 = ((MosWF_TypedDataContext14)(cachedCompiledDataContext[22]));
                return refDataContext209.GetLocation<int>(refDataContext209.ValueType___Expr209Get, refDataContext209.ValueType___Expr209Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 210)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext14.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[22] == null)) {
                    cachedCompiledDataContext[22] = new MosWF_TypedDataContext14(locations, activityContext, true);
                }
                MosWF_TypedDataContext14 refDataContext210 = ((MosWF_TypedDataContext14)(cachedCompiledDataContext[22]));
                return refDataContext210.GetLocation<int>(refDataContext210.ValueType___Expr210Get, refDataContext210.ValueType___Expr210Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 211)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[21] == null)) {
                    cachedCompiledDataContext[21] = new MosWF_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext14_ForReadOnly valDataContext211 = ((MosWF_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[21]));
                return valDataContext211.ValueType___Expr211Get();
            }
            if ((expressionId == 212)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext15.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[23] == null)) {
                    cachedCompiledDataContext[23] = new MosWF_TypedDataContext15(locations, activityContext, true);
                }
                MosWF_TypedDataContext15 refDataContext212 = ((MosWF_TypedDataContext15)(cachedCompiledDataContext[23]));
                return refDataContext212.GetLocation<bool>(refDataContext212.ValueType___Expr212Get, refDataContext212.ValueType___Expr212Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 213)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext15.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[23] == null)) {
                    cachedCompiledDataContext[23] = new MosWF_TypedDataContext15(locations, activityContext, true);
                }
                MosWF_TypedDataContext15 refDataContext213 = ((MosWF_TypedDataContext15)(cachedCompiledDataContext[23]));
                return refDataContext213.GetLocation<bool>(refDataContext213.ValueType___Expr213Get, refDataContext213.ValueType___Expr213Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 214)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = MosWF_TypedDataContext15_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 25);
                if ((cachedCompiledDataContext[24] == null)) {
                    cachedCompiledDataContext[24] = new MosWF_TypedDataContext15_ForReadOnly(locations, activityContext, true);
                }
                MosWF_TypedDataContext15_ForReadOnly valDataContext214 = ((MosWF_TypedDataContext15_ForReadOnly)(cachedCompiledDataContext[24]));
                return valDataContext214.ValueType___Expr214Get();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.Location> locations) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((expressionId == 0)) {
                MosWF_TypedDataContext3 refDataContext0 = new MosWF_TypedDataContext3(locations, true);
                return refDataContext0.GetLocation<int>(refDataContext0.ValueType___Expr0Get, refDataContext0.ValueType___Expr0Set);
            }
            if ((expressionId == 1)) {
                MosWF_TypedDataContext3 refDataContext1 = new MosWF_TypedDataContext3(locations, true);
                return refDataContext1.GetLocation<int>(refDataContext1.ValueType___Expr1Get, refDataContext1.ValueType___Expr1Set);
            }
            if ((expressionId == 2)) {
                MosWF_TypedDataContext3 refDataContext2 = new MosWF_TypedDataContext3(locations, true);
                return refDataContext2.GetLocation<int>(refDataContext2.ValueType___Expr2Get, refDataContext2.ValueType___Expr2Set);
            }
            if ((expressionId == 3)) {
                MosWF_TypedDataContext3 refDataContext3 = new MosWF_TypedDataContext3(locations, true);
                return refDataContext3.GetLocation<int>(refDataContext3.ValueType___Expr3Get, refDataContext3.ValueType___Expr3Set);
            }
            if ((expressionId == 4)) {
                MosWF_TypedDataContext4_ForReadOnly valDataContext4 = new MosWF_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                MosWF_TypedDataContext4_ForReadOnly valDataContext5 = new MosWF_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                MosWF_TypedDataContext4 refDataContext6 = new MosWF_TypedDataContext4(locations, true);
                return refDataContext6.GetLocation<bool>(refDataContext6.ValueType___Expr6Get, refDataContext6.ValueType___Expr6Set);
            }
            if ((expressionId == 7)) {
                MosWF_TypedDataContext4 refDataContext7 = new MosWF_TypedDataContext4(locations, true);
                return refDataContext7.GetLocation<bool>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set);
            }
            if ((expressionId == 8)) {
                MosWF_TypedDataContext4 refDataContext8 = new MosWF_TypedDataContext4(locations, true);
                return refDataContext8.GetLocation<bool>(refDataContext8.ValueType___Expr8Get, refDataContext8.ValueType___Expr8Set);
            }
            if ((expressionId == 9)) {
                MosWF_TypedDataContext4 refDataContext9 = new MosWF_TypedDataContext4(locations, true);
                return refDataContext9.GetLocation<bool>(refDataContext9.ValueType___Expr9Get, refDataContext9.ValueType___Expr9Set);
            }
            if ((expressionId == 10)) {
                MosWF_TypedDataContext4 refDataContext10 = new MosWF_TypedDataContext4(locations, true);
                return refDataContext10.GetLocation<bool>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set);
            }
            if ((expressionId == 11)) {
                MosWF_TypedDataContext4 refDataContext11 = new MosWF_TypedDataContext4(locations, true);
                return refDataContext11.GetLocation<bool>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set);
            }
            if ((expressionId == 12)) {
                MosWF_TypedDataContext4 refDataContext12 = new MosWF_TypedDataContext4(locations, true);
                return refDataContext12.GetLocation<bool>(refDataContext12.ValueType___Expr12Get, refDataContext12.ValueType___Expr12Set);
            }
            if ((expressionId == 13)) {
                MosWF_TypedDataContext4_ForReadOnly valDataContext13 = new MosWF_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                MosWF_TypedDataContext4 refDataContext14 = new MosWF_TypedDataContext4(locations, true);
                return refDataContext14.GetLocation<int>(refDataContext14.ValueType___Expr14Get, refDataContext14.ValueType___Expr14Set);
            }
            if ((expressionId == 15)) {
                MosWF_TypedDataContext4 refDataContext15 = new MosWF_TypedDataContext4(locations, true);
                return refDataContext15.GetLocation<int>(refDataContext15.ValueType___Expr15Get, refDataContext15.ValueType___Expr15Set);
            }
            if ((expressionId == 16)) {
                MosWF_TypedDataContext4 refDataContext16 = new MosWF_TypedDataContext4(locations, true);
                return refDataContext16.GetLocation<int>(refDataContext16.ValueType___Expr16Get, refDataContext16.ValueType___Expr16Set);
            }
            if ((expressionId == 17)) {
                MosWF_TypedDataContext4 refDataContext17 = new MosWF_TypedDataContext4(locations, true);
                return refDataContext17.GetLocation<int>(refDataContext17.ValueType___Expr17Get, refDataContext17.ValueType___Expr17Set);
            }
            if ((expressionId == 18)) {
                MosWF_TypedDataContext4_ForReadOnly valDataContext18 = new MosWF_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext18.ValueType___Expr18Get();
            }
            if ((expressionId == 19)) {
                MosWF_TypedDataContext5_ForReadOnly valDataContext19 = new MosWF_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext19.ValueType___Expr19Get();
            }
            if ((expressionId == 20)) {
                MosWF_TypedDataContext5_ForReadOnly valDataContext20 = new MosWF_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                MosWF_TypedDataContext5 refDataContext21 = new MosWF_TypedDataContext5(locations, true);
                return refDataContext21.GetLocation<bool>(refDataContext21.ValueType___Expr21Get, refDataContext21.ValueType___Expr21Set);
            }
            if ((expressionId == 22)) {
                MosWF_TypedDataContext5 refDataContext22 = new MosWF_TypedDataContext5(locations, true);
                return refDataContext22.GetLocation<bool>(refDataContext22.ValueType___Expr22Get, refDataContext22.ValueType___Expr22Set);
            }
            if ((expressionId == 23)) {
                MosWF_TypedDataContext5 refDataContext23 = new MosWF_TypedDataContext5(locations, true);
                return refDataContext23.GetLocation<bool>(refDataContext23.ValueType___Expr23Get, refDataContext23.ValueType___Expr23Set);
            }
            if ((expressionId == 24)) {
                MosWF_TypedDataContext5 refDataContext24 = new MosWF_TypedDataContext5(locations, true);
                return refDataContext24.GetLocation<bool>(refDataContext24.ValueType___Expr24Get, refDataContext24.ValueType___Expr24Set);
            }
            if ((expressionId == 25)) {
                MosWF_TypedDataContext5 refDataContext25 = new MosWF_TypedDataContext5(locations, true);
                return refDataContext25.GetLocation<bool>(refDataContext25.ValueType___Expr25Get, refDataContext25.ValueType___Expr25Set);
            }
            if ((expressionId == 26)) {
                MosWF_TypedDataContext5 refDataContext26 = new MosWF_TypedDataContext5(locations, true);
                return refDataContext26.GetLocation<bool>(refDataContext26.ValueType___Expr26Get, refDataContext26.ValueType___Expr26Set);
            }
            if ((expressionId == 27)) {
                MosWF_TypedDataContext5 refDataContext27 = new MosWF_TypedDataContext5(locations, true);
                return refDataContext27.GetLocation<bool>(refDataContext27.ValueType___Expr27Get, refDataContext27.ValueType___Expr27Set);
            }
            if ((expressionId == 28)) {
                MosWF_TypedDataContext5_ForReadOnly valDataContext28 = new MosWF_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext28.ValueType___Expr28Get();
            }
            if ((expressionId == 29)) {
                MosWF_TypedDataContext5_ForReadOnly valDataContext29 = new MosWF_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext29.ValueType___Expr29Get();
            }
            if ((expressionId == 30)) {
                MosWF_TypedDataContext5 refDataContext30 = new MosWF_TypedDataContext5(locations, true);
                return refDataContext30.GetLocation<int>(refDataContext30.ValueType___Expr30Get, refDataContext30.ValueType___Expr30Set);
            }
            if ((expressionId == 31)) {
                MosWF_TypedDataContext5 refDataContext31 = new MosWF_TypedDataContext5(locations, true);
                return refDataContext31.GetLocation<int>(refDataContext31.ValueType___Expr31Get, refDataContext31.ValueType___Expr31Set);
            }
            if ((expressionId == 32)) {
                MosWF_TypedDataContext5 refDataContext32 = new MosWF_TypedDataContext5(locations, true);
                return refDataContext32.GetLocation<int>(refDataContext32.ValueType___Expr32Get, refDataContext32.ValueType___Expr32Set);
            }
            if ((expressionId == 33)) {
                MosWF_TypedDataContext5 refDataContext33 = new MosWF_TypedDataContext5(locations, true);
                return refDataContext33.GetLocation<int>(refDataContext33.ValueType___Expr33Get, refDataContext33.ValueType___Expr33Set);
            }
            if ((expressionId == 34)) {
                MosWF_TypedDataContext5_ForReadOnly valDataContext34 = new MosWF_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext34.ValueType___Expr34Get();
            }
            if ((expressionId == 35)) {
                MosWF_TypedDataContext5 refDataContext35 = new MosWF_TypedDataContext5(locations, true);
                return refDataContext35.GetLocation<int>(refDataContext35.ValueType___Expr35Get, refDataContext35.ValueType___Expr35Set);
            }
            if ((expressionId == 36)) {
                MosWF_TypedDataContext5 refDataContext36 = new MosWF_TypedDataContext5(locations, true);
                return refDataContext36.GetLocation<int>(refDataContext36.ValueType___Expr36Get, refDataContext36.ValueType___Expr36Set);
            }
            if ((expressionId == 37)) {
                MosWF_TypedDataContext5 refDataContext37 = new MosWF_TypedDataContext5(locations, true);
                return refDataContext37.GetLocation<int>(refDataContext37.ValueType___Expr37Get, refDataContext37.ValueType___Expr37Set);
            }
            if ((expressionId == 38)) {
                MosWF_TypedDataContext5 refDataContext38 = new MosWF_TypedDataContext5(locations, true);
                return refDataContext38.GetLocation<int>(refDataContext38.ValueType___Expr38Get, refDataContext38.ValueType___Expr38Set);
            }
            if ((expressionId == 39)) {
                MosWF_TypedDataContext5_ForReadOnly valDataContext39 = new MosWF_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext39.ValueType___Expr39Get();
            }
            if ((expressionId == 40)) {
                MosWF_TypedDataContext5 refDataContext40 = new MosWF_TypedDataContext5(locations, true);
                return refDataContext40.GetLocation<int>(refDataContext40.ValueType___Expr40Get, refDataContext40.ValueType___Expr40Set);
            }
            if ((expressionId == 41)) {
                MosWF_TypedDataContext5 refDataContext41 = new MosWF_TypedDataContext5(locations, true);
                return refDataContext41.GetLocation<int>(refDataContext41.ValueType___Expr41Get, refDataContext41.ValueType___Expr41Set);
            }
            if ((expressionId == 42)) {
                MosWF_TypedDataContext5 refDataContext42 = new MosWF_TypedDataContext5(locations, true);
                return refDataContext42.GetLocation<int>(refDataContext42.ValueType___Expr42Get, refDataContext42.ValueType___Expr42Set);
            }
            if ((expressionId == 43)) {
                MosWF_TypedDataContext5 refDataContext43 = new MosWF_TypedDataContext5(locations, true);
                return refDataContext43.GetLocation<int>(refDataContext43.ValueType___Expr43Get, refDataContext43.ValueType___Expr43Set);
            }
            if ((expressionId == 44)) {
                MosWF_TypedDataContext6_ForReadOnly valDataContext44 = new MosWF_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext44.ValueType___Expr44Get();
            }
            if ((expressionId == 45)) {
                MosWF_TypedDataContext6_ForReadOnly valDataContext45 = new MosWF_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext45.ValueType___Expr45Get();
            }
            if ((expressionId == 46)) {
                MosWF_TypedDataContext6_ForReadOnly valDataContext46 = new MosWF_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext46.ValueType___Expr46Get();
            }
            if ((expressionId == 47)) {
                MosWF_TypedDataContext6 refDataContext47 = new MosWF_TypedDataContext6(locations, true);
                return refDataContext47.GetLocation<bool>(refDataContext47.ValueType___Expr47Get, refDataContext47.ValueType___Expr47Set);
            }
            if ((expressionId == 48)) {
                MosWF_TypedDataContext6 refDataContext48 = new MosWF_TypedDataContext6(locations, true);
                return refDataContext48.GetLocation<bool>(refDataContext48.ValueType___Expr48Get, refDataContext48.ValueType___Expr48Set);
            }
            if ((expressionId == 49)) {
                MosWF_TypedDataContext6 refDataContext49 = new MosWF_TypedDataContext6(locations, true);
                return refDataContext49.GetLocation<bool>(refDataContext49.ValueType___Expr49Get, refDataContext49.ValueType___Expr49Set);
            }
            if ((expressionId == 50)) {
                MosWF_TypedDataContext6 refDataContext50 = new MosWF_TypedDataContext6(locations, true);
                return refDataContext50.GetLocation<bool>(refDataContext50.ValueType___Expr50Get, refDataContext50.ValueType___Expr50Set);
            }
            if ((expressionId == 51)) {
                MosWF_TypedDataContext6 refDataContext51 = new MosWF_TypedDataContext6(locations, true);
                return refDataContext51.GetLocation<bool>(refDataContext51.ValueType___Expr51Get, refDataContext51.ValueType___Expr51Set);
            }
            if ((expressionId == 52)) {
                MosWF_TypedDataContext6 refDataContext52 = new MosWF_TypedDataContext6(locations, true);
                return refDataContext52.GetLocation<bool>(refDataContext52.ValueType___Expr52Get, refDataContext52.ValueType___Expr52Set);
            }
            if ((expressionId == 53)) {
                MosWF_TypedDataContext6 refDataContext53 = new MosWF_TypedDataContext6(locations, true);
                return refDataContext53.GetLocation<bool>(refDataContext53.ValueType___Expr53Get, refDataContext53.ValueType___Expr53Set);
            }
            if ((expressionId == 54)) {
                MosWF_TypedDataContext6 refDataContext54 = new MosWF_TypedDataContext6(locations, true);
                return refDataContext54.GetLocation<bool>(refDataContext54.ValueType___Expr54Get, refDataContext54.ValueType___Expr54Set);
            }
            if ((expressionId == 55)) {
                MosWF_TypedDataContext6 refDataContext55 = new MosWF_TypedDataContext6(locations, true);
                return refDataContext55.GetLocation<bool>(refDataContext55.ValueType___Expr55Get, refDataContext55.ValueType___Expr55Set);
            }
            if ((expressionId == 56)) {
                MosWF_TypedDataContext6_ForReadOnly valDataContext56 = new MosWF_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext56.ValueType___Expr56Get();
            }
            if ((expressionId == 57)) {
                MosWF_TypedDataContext6_ForReadOnly valDataContext57 = new MosWF_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext57.ValueType___Expr57Get();
            }
            if ((expressionId == 58)) {
                MosWF_TypedDataContext6 refDataContext58 = new MosWF_TypedDataContext6(locations, true);
                return refDataContext58.GetLocation<int>(refDataContext58.ValueType___Expr58Get, refDataContext58.ValueType___Expr58Set);
            }
            if ((expressionId == 59)) {
                MosWF_TypedDataContext6 refDataContext59 = new MosWF_TypedDataContext6(locations, true);
                return refDataContext59.GetLocation<int>(refDataContext59.ValueType___Expr59Get, refDataContext59.ValueType___Expr59Set);
            }
            if ((expressionId == 60)) {
                MosWF_TypedDataContext6 refDataContext60 = new MosWF_TypedDataContext6(locations, true);
                return refDataContext60.GetLocation<int>(refDataContext60.ValueType___Expr60Get, refDataContext60.ValueType___Expr60Set);
            }
            if ((expressionId == 61)) {
                MosWF_TypedDataContext6 refDataContext61 = new MosWF_TypedDataContext6(locations, true);
                return refDataContext61.GetLocation<int>(refDataContext61.ValueType___Expr61Get, refDataContext61.ValueType___Expr61Set);
            }
            if ((expressionId == 62)) {
                MosWF_TypedDataContext7_ForReadOnly valDataContext62 = new MosWF_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext62.ValueType___Expr62Get();
            }
            if ((expressionId == 63)) {
                MosWF_TypedDataContext7_ForReadOnly valDataContext63 = new MosWF_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext63.ValueType___Expr63Get();
            }
            if ((expressionId == 64)) {
                MosWF_TypedDataContext7_ForReadOnly valDataContext64 = new MosWF_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext64.ValueType___Expr64Get();
            }
            if ((expressionId == 65)) {
                MosWF_TypedDataContext7 refDataContext65 = new MosWF_TypedDataContext7(locations, true);
                return refDataContext65.GetLocation<bool>(refDataContext65.ValueType___Expr65Get, refDataContext65.ValueType___Expr65Set);
            }
            if ((expressionId == 66)) {
                MosWF_TypedDataContext7 refDataContext66 = new MosWF_TypedDataContext7(locations, true);
                return refDataContext66.GetLocation<bool>(refDataContext66.ValueType___Expr66Get, refDataContext66.ValueType___Expr66Set);
            }
            if ((expressionId == 67)) {
                MosWF_TypedDataContext7 refDataContext67 = new MosWF_TypedDataContext7(locations, true);
                return refDataContext67.GetLocation<bool>(refDataContext67.ValueType___Expr67Get, refDataContext67.ValueType___Expr67Set);
            }
            if ((expressionId == 68)) {
                MosWF_TypedDataContext7 refDataContext68 = new MosWF_TypedDataContext7(locations, true);
                return refDataContext68.GetLocation<bool>(refDataContext68.ValueType___Expr68Get, refDataContext68.ValueType___Expr68Set);
            }
            if ((expressionId == 69)) {
                MosWF_TypedDataContext7 refDataContext69 = new MosWF_TypedDataContext7(locations, true);
                return refDataContext69.GetLocation<bool>(refDataContext69.ValueType___Expr69Get, refDataContext69.ValueType___Expr69Set);
            }
            if ((expressionId == 70)) {
                MosWF_TypedDataContext7 refDataContext70 = new MosWF_TypedDataContext7(locations, true);
                return refDataContext70.GetLocation<bool>(refDataContext70.ValueType___Expr70Get, refDataContext70.ValueType___Expr70Set);
            }
            if ((expressionId == 71)) {
                MosWF_TypedDataContext7 refDataContext71 = new MosWF_TypedDataContext7(locations, true);
                return refDataContext71.GetLocation<bool>(refDataContext71.ValueType___Expr71Get, refDataContext71.ValueType___Expr71Set);
            }
            if ((expressionId == 72)) {
                MosWF_TypedDataContext7 refDataContext72 = new MosWF_TypedDataContext7(locations, true);
                return refDataContext72.GetLocation<bool>(refDataContext72.ValueType___Expr72Get, refDataContext72.ValueType___Expr72Set);
            }
            if ((expressionId == 73)) {
                MosWF_TypedDataContext7 refDataContext73 = new MosWF_TypedDataContext7(locations, true);
                return refDataContext73.GetLocation<bool>(refDataContext73.ValueType___Expr73Get, refDataContext73.ValueType___Expr73Set);
            }
            if ((expressionId == 74)) {
                MosWF_TypedDataContext7_ForReadOnly valDataContext74 = new MosWF_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext74.ValueType___Expr74Get();
            }
            if ((expressionId == 75)) {
                MosWF_TypedDataContext7_ForReadOnly valDataContext75 = new MosWF_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext75.ValueType___Expr75Get();
            }
            if ((expressionId == 76)) {
                MosWF_TypedDataContext7 refDataContext76 = new MosWF_TypedDataContext7(locations, true);
                return refDataContext76.GetLocation<int>(refDataContext76.ValueType___Expr76Get, refDataContext76.ValueType___Expr76Set);
            }
            if ((expressionId == 77)) {
                MosWF_TypedDataContext7 refDataContext77 = new MosWF_TypedDataContext7(locations, true);
                return refDataContext77.GetLocation<int>(refDataContext77.ValueType___Expr77Get, refDataContext77.ValueType___Expr77Set);
            }
            if ((expressionId == 78)) {
                MosWF_TypedDataContext7 refDataContext78 = new MosWF_TypedDataContext7(locations, true);
                return refDataContext78.GetLocation<int>(refDataContext78.ValueType___Expr78Get, refDataContext78.ValueType___Expr78Set);
            }
            if ((expressionId == 79)) {
                MosWF_TypedDataContext7 refDataContext79 = new MosWF_TypedDataContext7(locations, true);
                return refDataContext79.GetLocation<int>(refDataContext79.ValueType___Expr79Get, refDataContext79.ValueType___Expr79Set);
            }
            if ((expressionId == 80)) {
                MosWF_TypedDataContext7_ForReadOnly valDataContext80 = new MosWF_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext80.ValueType___Expr80Get();
            }
            if ((expressionId == 81)) {
                MosWF_TypedDataContext7 refDataContext81 = new MosWF_TypedDataContext7(locations, true);
                return refDataContext81.GetLocation<int>(refDataContext81.ValueType___Expr81Get, refDataContext81.ValueType___Expr81Set);
            }
            if ((expressionId == 82)) {
                MosWF_TypedDataContext7 refDataContext82 = new MosWF_TypedDataContext7(locations, true);
                return refDataContext82.GetLocation<int>(refDataContext82.ValueType___Expr82Get, refDataContext82.ValueType___Expr82Set);
            }
            if ((expressionId == 83)) {
                MosWF_TypedDataContext7 refDataContext83 = new MosWF_TypedDataContext7(locations, true);
                return refDataContext83.GetLocation<int>(refDataContext83.ValueType___Expr83Get, refDataContext83.ValueType___Expr83Set);
            }
            if ((expressionId == 84)) {
                MosWF_TypedDataContext7 refDataContext84 = new MosWF_TypedDataContext7(locations, true);
                return refDataContext84.GetLocation<int>(refDataContext84.ValueType___Expr84Get, refDataContext84.ValueType___Expr84Set);
            }
            if ((expressionId == 85)) {
                MosWF_TypedDataContext8_ForReadOnly valDataContext85 = new MosWF_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext85.ValueType___Expr85Get();
            }
            if ((expressionId == 86)) {
                MosWF_TypedDataContext8_ForReadOnly valDataContext86 = new MosWF_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext86.ValueType___Expr86Get();
            }
            if ((expressionId == 87)) {
                MosWF_TypedDataContext8_ForReadOnly valDataContext87 = new MosWF_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext87.ValueType___Expr87Get();
            }
            if ((expressionId == 88)) {
                MosWF_TypedDataContext8 refDataContext88 = new MosWF_TypedDataContext8(locations, true);
                return refDataContext88.GetLocation<bool>(refDataContext88.ValueType___Expr88Get, refDataContext88.ValueType___Expr88Set);
            }
            if ((expressionId == 89)) {
                MosWF_TypedDataContext8 refDataContext89 = new MosWF_TypedDataContext8(locations, true);
                return refDataContext89.GetLocation<bool>(refDataContext89.ValueType___Expr89Get, refDataContext89.ValueType___Expr89Set);
            }
            if ((expressionId == 90)) {
                MosWF_TypedDataContext8 refDataContext90 = new MosWF_TypedDataContext8(locations, true);
                return refDataContext90.GetLocation<bool>(refDataContext90.ValueType___Expr90Get, refDataContext90.ValueType___Expr90Set);
            }
            if ((expressionId == 91)) {
                MosWF_TypedDataContext8 refDataContext91 = new MosWF_TypedDataContext8(locations, true);
                return refDataContext91.GetLocation<bool>(refDataContext91.ValueType___Expr91Get, refDataContext91.ValueType___Expr91Set);
            }
            if ((expressionId == 92)) {
                MosWF_TypedDataContext8 refDataContext92 = new MosWF_TypedDataContext8(locations, true);
                return refDataContext92.GetLocation<bool>(refDataContext92.ValueType___Expr92Get, refDataContext92.ValueType___Expr92Set);
            }
            if ((expressionId == 93)) {
                MosWF_TypedDataContext8 refDataContext93 = new MosWF_TypedDataContext8(locations, true);
                return refDataContext93.GetLocation<bool>(refDataContext93.ValueType___Expr93Get, refDataContext93.ValueType___Expr93Set);
            }
            if ((expressionId == 94)) {
                MosWF_TypedDataContext8 refDataContext94 = new MosWF_TypedDataContext8(locations, true);
                return refDataContext94.GetLocation<bool>(refDataContext94.ValueType___Expr94Get, refDataContext94.ValueType___Expr94Set);
            }
            if ((expressionId == 95)) {
                MosWF_TypedDataContext8 refDataContext95 = new MosWF_TypedDataContext8(locations, true);
                return refDataContext95.GetLocation<bool>(refDataContext95.ValueType___Expr95Get, refDataContext95.ValueType___Expr95Set);
            }
            if ((expressionId == 96)) {
                MosWF_TypedDataContext8 refDataContext96 = new MosWF_TypedDataContext8(locations, true);
                return refDataContext96.GetLocation<bool>(refDataContext96.ValueType___Expr96Get, refDataContext96.ValueType___Expr96Set);
            }
            if ((expressionId == 97)) {
                MosWF_TypedDataContext8_ForReadOnly valDataContext97 = new MosWF_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext97.ValueType___Expr97Get();
            }
            if ((expressionId == 98)) {
                MosWF_TypedDataContext8 refDataContext98 = new MosWF_TypedDataContext8(locations, true);
                return refDataContext98.GetLocation<int>(refDataContext98.ValueType___Expr98Get, refDataContext98.ValueType___Expr98Set);
            }
            if ((expressionId == 99)) {
                MosWF_TypedDataContext8 refDataContext99 = new MosWF_TypedDataContext8(locations, true);
                return refDataContext99.GetLocation<int>(refDataContext99.ValueType___Expr99Get, refDataContext99.ValueType___Expr99Set);
            }
            if ((expressionId == 100)) {
                MosWF_TypedDataContext8 refDataContext100 = new MosWF_TypedDataContext8(locations, true);
                return refDataContext100.GetLocation<int>(refDataContext100.ValueType___Expr100Get, refDataContext100.ValueType___Expr100Set);
            }
            if ((expressionId == 101)) {
                MosWF_TypedDataContext8 refDataContext101 = new MosWF_TypedDataContext8(locations, true);
                return refDataContext101.GetLocation<int>(refDataContext101.ValueType___Expr101Get, refDataContext101.ValueType___Expr101Set);
            }
            if ((expressionId == 102)) {
                MosWF_TypedDataContext8_ForReadOnly valDataContext102 = new MosWF_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext102.ValueType___Expr102Get();
            }
            if ((expressionId == 103)) {
                MosWF_TypedDataContext8 refDataContext103 = new MosWF_TypedDataContext8(locations, true);
                return refDataContext103.GetLocation<int>(refDataContext103.ValueType___Expr103Get, refDataContext103.ValueType___Expr103Set);
            }
            if ((expressionId == 104)) {
                MosWF_TypedDataContext8 refDataContext104 = new MosWF_TypedDataContext8(locations, true);
                return refDataContext104.GetLocation<int>(refDataContext104.ValueType___Expr104Get, refDataContext104.ValueType___Expr104Set);
            }
            if ((expressionId == 105)) {
                MosWF_TypedDataContext8 refDataContext105 = new MosWF_TypedDataContext8(locations, true);
                return refDataContext105.GetLocation<int>(refDataContext105.ValueType___Expr105Get, refDataContext105.ValueType___Expr105Set);
            }
            if ((expressionId == 106)) {
                MosWF_TypedDataContext8 refDataContext106 = new MosWF_TypedDataContext8(locations, true);
                return refDataContext106.GetLocation<int>(refDataContext106.ValueType___Expr106Get, refDataContext106.ValueType___Expr106Set);
            }
            if ((expressionId == 107)) {
                MosWF_TypedDataContext8_ForReadOnly valDataContext107 = new MosWF_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext107.ValueType___Expr107Get();
            }
            if ((expressionId == 108)) {
                MosWF_TypedDataContext9_ForReadOnly valDataContext108 = new MosWF_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext108.ValueType___Expr108Get();
            }
            if ((expressionId == 109)) {
                MosWF_TypedDataContext9_ForReadOnly valDataContext109 = new MosWF_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext109.ValueType___Expr109Get();
            }
            if ((expressionId == 110)) {
                MosWF_TypedDataContext9_ForReadOnly valDataContext110 = new MosWF_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext110.ValueType___Expr110Get();
            }
            if ((expressionId == 111)) {
                MosWF_TypedDataContext9 refDataContext111 = new MosWF_TypedDataContext9(locations, true);
                return refDataContext111.GetLocation<bool>(refDataContext111.ValueType___Expr111Get, refDataContext111.ValueType___Expr111Set);
            }
            if ((expressionId == 112)) {
                MosWF_TypedDataContext9 refDataContext112 = new MosWF_TypedDataContext9(locations, true);
                return refDataContext112.GetLocation<bool>(refDataContext112.ValueType___Expr112Get, refDataContext112.ValueType___Expr112Set);
            }
            if ((expressionId == 113)) {
                MosWF_TypedDataContext9 refDataContext113 = new MosWF_TypedDataContext9(locations, true);
                return refDataContext113.GetLocation<bool>(refDataContext113.ValueType___Expr113Get, refDataContext113.ValueType___Expr113Set);
            }
            if ((expressionId == 114)) {
                MosWF_TypedDataContext9 refDataContext114 = new MosWF_TypedDataContext9(locations, true);
                return refDataContext114.GetLocation<bool>(refDataContext114.ValueType___Expr114Get, refDataContext114.ValueType___Expr114Set);
            }
            if ((expressionId == 115)) {
                MosWF_TypedDataContext9 refDataContext115 = new MosWF_TypedDataContext9(locations, true);
                return refDataContext115.GetLocation<bool>(refDataContext115.ValueType___Expr115Get, refDataContext115.ValueType___Expr115Set);
            }
            if ((expressionId == 116)) {
                MosWF_TypedDataContext9 refDataContext116 = new MosWF_TypedDataContext9(locations, true);
                return refDataContext116.GetLocation<bool>(refDataContext116.ValueType___Expr116Get, refDataContext116.ValueType___Expr116Set);
            }
            if ((expressionId == 117)) {
                MosWF_TypedDataContext9 refDataContext117 = new MosWF_TypedDataContext9(locations, true);
                return refDataContext117.GetLocation<bool>(refDataContext117.ValueType___Expr117Get, refDataContext117.ValueType___Expr117Set);
            }
            if ((expressionId == 118)) {
                MosWF_TypedDataContext9 refDataContext118 = new MosWF_TypedDataContext9(locations, true);
                return refDataContext118.GetLocation<bool>(refDataContext118.ValueType___Expr118Get, refDataContext118.ValueType___Expr118Set);
            }
            if ((expressionId == 119)) {
                MosWF_TypedDataContext9 refDataContext119 = new MosWF_TypedDataContext9(locations, true);
                return refDataContext119.GetLocation<bool>(refDataContext119.ValueType___Expr119Get, refDataContext119.ValueType___Expr119Set);
            }
            if ((expressionId == 120)) {
                MosWF_TypedDataContext9_ForReadOnly valDataContext120 = new MosWF_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext120.ValueType___Expr120Get();
            }
            if ((expressionId == 121)) {
                MosWF_TypedDataContext9 refDataContext121 = new MosWF_TypedDataContext9(locations, true);
                return refDataContext121.GetLocation<int>(refDataContext121.ValueType___Expr121Get, refDataContext121.ValueType___Expr121Set);
            }
            if ((expressionId == 122)) {
                MosWF_TypedDataContext9_ForReadOnly valDataContext122 = new MosWF_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext122.ValueType___Expr122Get();
            }
            if ((expressionId == 123)) {
                MosWF_TypedDataContext9_ForReadOnly valDataContext123 = new MosWF_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext123.ValueType___Expr123Get();
            }
            if ((expressionId == 124)) {
                MosWF_TypedDataContext9 refDataContext124 = new MosWF_TypedDataContext9(locations, true);
                return refDataContext124.GetLocation<int>(refDataContext124.ValueType___Expr124Get, refDataContext124.ValueType___Expr124Set);
            }
            if ((expressionId == 125)) {
                MosWF_TypedDataContext9 refDataContext125 = new MosWF_TypedDataContext9(locations, true);
                return refDataContext125.GetLocation<int>(refDataContext125.ValueType___Expr125Get, refDataContext125.ValueType___Expr125Set);
            }
            if ((expressionId == 126)) {
                MosWF_TypedDataContext9 refDataContext126 = new MosWF_TypedDataContext9(locations, true);
                return refDataContext126.GetLocation<int>(refDataContext126.ValueType___Expr126Get, refDataContext126.ValueType___Expr126Set);
            }
            if ((expressionId == 127)) {
                MosWF_TypedDataContext9 refDataContext127 = new MosWF_TypedDataContext9(locations, true);
                return refDataContext127.GetLocation<int>(refDataContext127.ValueType___Expr127Get, refDataContext127.ValueType___Expr127Set);
            }
            if ((expressionId == 128)) {
                MosWF_TypedDataContext9_ForReadOnly valDataContext128 = new MosWF_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext128.ValueType___Expr128Get();
            }
            if ((expressionId == 129)) {
                MosWF_TypedDataContext9_ForReadOnly valDataContext129 = new MosWF_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext129.ValueType___Expr129Get();
            }
            if ((expressionId == 130)) {
                MosWF_TypedDataContext9 refDataContext130 = new MosWF_TypedDataContext9(locations, true);
                return refDataContext130.GetLocation<int>(refDataContext130.ValueType___Expr130Get, refDataContext130.ValueType___Expr130Set);
            }
            if ((expressionId == 131)) {
                MosWF_TypedDataContext9 refDataContext131 = new MosWF_TypedDataContext9(locations, true);
                return refDataContext131.GetLocation<int>(refDataContext131.ValueType___Expr131Get, refDataContext131.ValueType___Expr131Set);
            }
            if ((expressionId == 132)) {
                MosWF_TypedDataContext9 refDataContext132 = new MosWF_TypedDataContext9(locations, true);
                return refDataContext132.GetLocation<int>(refDataContext132.ValueType___Expr132Get, refDataContext132.ValueType___Expr132Set);
            }
            if ((expressionId == 133)) {
                MosWF_TypedDataContext9 refDataContext133 = new MosWF_TypedDataContext9(locations, true);
                return refDataContext133.GetLocation<int>(refDataContext133.ValueType___Expr133Get, refDataContext133.ValueType___Expr133Set);
            }
            if ((expressionId == 134)) {
                MosWF_TypedDataContext9 refDataContext134 = new MosWF_TypedDataContext9(locations, true);
                return refDataContext134.GetLocation<int>(refDataContext134.ValueType___Expr134Get, refDataContext134.ValueType___Expr134Set);
            }
            if ((expressionId == 135)) {
                MosWF_TypedDataContext9_ForReadOnly valDataContext135 = new MosWF_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext135.ValueType___Expr135Get();
            }
            if ((expressionId == 136)) {
                MosWF_TypedDataContext9 refDataContext136 = new MosWF_TypedDataContext9(locations, true);
                return refDataContext136.GetLocation<int>(refDataContext136.ValueType___Expr136Get, refDataContext136.ValueType___Expr136Set);
            }
            if ((expressionId == 137)) {
                MosWF_TypedDataContext10_ForReadOnly valDataContext137 = new MosWF_TypedDataContext10_ForReadOnly(locations, true);
                return valDataContext137.ValueType___Expr137Get();
            }
            if ((expressionId == 138)) {
                MosWF_TypedDataContext10_ForReadOnly valDataContext138 = new MosWF_TypedDataContext10_ForReadOnly(locations, true);
                return valDataContext138.ValueType___Expr138Get();
            }
            if ((expressionId == 139)) {
                MosWF_TypedDataContext10 refDataContext139 = new MosWF_TypedDataContext10(locations, true);
                return refDataContext139.GetLocation<bool>(refDataContext139.ValueType___Expr139Get, refDataContext139.ValueType___Expr139Set);
            }
            if ((expressionId == 140)) {
                MosWF_TypedDataContext10 refDataContext140 = new MosWF_TypedDataContext10(locations, true);
                return refDataContext140.GetLocation<bool>(refDataContext140.ValueType___Expr140Get, refDataContext140.ValueType___Expr140Set);
            }
            if ((expressionId == 141)) {
                MosWF_TypedDataContext10 refDataContext141 = new MosWF_TypedDataContext10(locations, true);
                return refDataContext141.GetLocation<bool>(refDataContext141.ValueType___Expr141Get, refDataContext141.ValueType___Expr141Set);
            }
            if ((expressionId == 142)) {
                MosWF_TypedDataContext10 refDataContext142 = new MosWF_TypedDataContext10(locations, true);
                return refDataContext142.GetLocation<bool>(refDataContext142.ValueType___Expr142Get, refDataContext142.ValueType___Expr142Set);
            }
            if ((expressionId == 143)) {
                MosWF_TypedDataContext10 refDataContext143 = new MosWF_TypedDataContext10(locations, true);
                return refDataContext143.GetLocation<bool>(refDataContext143.ValueType___Expr143Get, refDataContext143.ValueType___Expr143Set);
            }
            if ((expressionId == 144)) {
                MosWF_TypedDataContext10 refDataContext144 = new MosWF_TypedDataContext10(locations, true);
                return refDataContext144.GetLocation<bool>(refDataContext144.ValueType___Expr144Get, refDataContext144.ValueType___Expr144Set);
            }
            if ((expressionId == 145)) {
                MosWF_TypedDataContext10 refDataContext145 = new MosWF_TypedDataContext10(locations, true);
                return refDataContext145.GetLocation<bool>(refDataContext145.ValueType___Expr145Get, refDataContext145.ValueType___Expr145Set);
            }
            if ((expressionId == 146)) {
                MosWF_TypedDataContext10_ForReadOnly valDataContext146 = new MosWF_TypedDataContext10_ForReadOnly(locations, true);
                return valDataContext146.ValueType___Expr146Get();
            }
            if ((expressionId == 147)) {
                MosWF_TypedDataContext10 refDataContext147 = new MosWF_TypedDataContext10(locations, true);
                return refDataContext147.GetLocation<int>(refDataContext147.ValueType___Expr147Get, refDataContext147.ValueType___Expr147Set);
            }
            if ((expressionId == 148)) {
                MosWF_TypedDataContext10 refDataContext148 = new MosWF_TypedDataContext10(locations, true);
                return refDataContext148.GetLocation<int>(refDataContext148.ValueType___Expr148Get, refDataContext148.ValueType___Expr148Set);
            }
            if ((expressionId == 149)) {
                MosWF_TypedDataContext10 refDataContext149 = new MosWF_TypedDataContext10(locations, true);
                return refDataContext149.GetLocation<int>(refDataContext149.ValueType___Expr149Get, refDataContext149.ValueType___Expr149Set);
            }
            if ((expressionId == 150)) {
                MosWF_TypedDataContext10 refDataContext150 = new MosWF_TypedDataContext10(locations, true);
                return refDataContext150.GetLocation<int>(refDataContext150.ValueType___Expr150Get, refDataContext150.ValueType___Expr150Set);
            }
            if ((expressionId == 151)) {
                MosWF_TypedDataContext10_ForReadOnly valDataContext151 = new MosWF_TypedDataContext10_ForReadOnly(locations, true);
                return valDataContext151.ValueType___Expr151Get();
            }
            if ((expressionId == 152)) {
                MosWF_TypedDataContext11_ForReadOnly valDataContext152 = new MosWF_TypedDataContext11_ForReadOnly(locations, true);
                return valDataContext152.ValueType___Expr152Get();
            }
            if ((expressionId == 153)) {
                MosWF_TypedDataContext11_ForReadOnly valDataContext153 = new MosWF_TypedDataContext11_ForReadOnly(locations, true);
                return valDataContext153.ValueType___Expr153Get();
            }
            if ((expressionId == 154)) {
                MosWF_TypedDataContext11 refDataContext154 = new MosWF_TypedDataContext11(locations, true);
                return refDataContext154.GetLocation<bool>(refDataContext154.ValueType___Expr154Get, refDataContext154.ValueType___Expr154Set);
            }
            if ((expressionId == 155)) {
                MosWF_TypedDataContext11 refDataContext155 = new MosWF_TypedDataContext11(locations, true);
                return refDataContext155.GetLocation<bool>(refDataContext155.ValueType___Expr155Get, refDataContext155.ValueType___Expr155Set);
            }
            if ((expressionId == 156)) {
                MosWF_TypedDataContext11 refDataContext156 = new MosWF_TypedDataContext11(locations, true);
                return refDataContext156.GetLocation<bool>(refDataContext156.ValueType___Expr156Get, refDataContext156.ValueType___Expr156Set);
            }
            if ((expressionId == 157)) {
                MosWF_TypedDataContext11 refDataContext157 = new MosWF_TypedDataContext11(locations, true);
                return refDataContext157.GetLocation<bool>(refDataContext157.ValueType___Expr157Get, refDataContext157.ValueType___Expr157Set);
            }
            if ((expressionId == 158)) {
                MosWF_TypedDataContext11 refDataContext158 = new MosWF_TypedDataContext11(locations, true);
                return refDataContext158.GetLocation<bool>(refDataContext158.ValueType___Expr158Get, refDataContext158.ValueType___Expr158Set);
            }
            if ((expressionId == 159)) {
                MosWF_TypedDataContext11 refDataContext159 = new MosWF_TypedDataContext11(locations, true);
                return refDataContext159.GetLocation<bool>(refDataContext159.ValueType___Expr159Get, refDataContext159.ValueType___Expr159Set);
            }
            if ((expressionId == 160)) {
                MosWF_TypedDataContext11 refDataContext160 = new MosWF_TypedDataContext11(locations, true);
                return refDataContext160.GetLocation<bool>(refDataContext160.ValueType___Expr160Get, refDataContext160.ValueType___Expr160Set);
            }
            if ((expressionId == 161)) {
                MosWF_TypedDataContext11_ForReadOnly valDataContext161 = new MosWF_TypedDataContext11_ForReadOnly(locations, true);
                return valDataContext161.ValueType___Expr161Get();
            }
            if ((expressionId == 162)) {
                MosWF_TypedDataContext11 refDataContext162 = new MosWF_TypedDataContext11(locations, true);
                return refDataContext162.GetLocation<int>(refDataContext162.ValueType___Expr162Get, refDataContext162.ValueType___Expr162Set);
            }
            if ((expressionId == 163)) {
                MosWF_TypedDataContext11 refDataContext163 = new MosWF_TypedDataContext11(locations, true);
                return refDataContext163.GetLocation<int>(refDataContext163.ValueType___Expr163Get, refDataContext163.ValueType___Expr163Set);
            }
            if ((expressionId == 164)) {
                MosWF_TypedDataContext11 refDataContext164 = new MosWF_TypedDataContext11(locations, true);
                return refDataContext164.GetLocation<int>(refDataContext164.ValueType___Expr164Get, refDataContext164.ValueType___Expr164Set);
            }
            if ((expressionId == 165)) {
                MosWF_TypedDataContext11 refDataContext165 = new MosWF_TypedDataContext11(locations, true);
                return refDataContext165.GetLocation<int>(refDataContext165.ValueType___Expr165Get, refDataContext165.ValueType___Expr165Set);
            }
            if ((expressionId == 166)) {
                MosWF_TypedDataContext11_ForReadOnly valDataContext166 = new MosWF_TypedDataContext11_ForReadOnly(locations, true);
                return valDataContext166.ValueType___Expr166Get();
            }
            if ((expressionId == 167)) {
                MosWF_TypedDataContext12_ForReadOnly valDataContext167 = new MosWF_TypedDataContext12_ForReadOnly(locations, true);
                return valDataContext167.ValueType___Expr167Get();
            }
            if ((expressionId == 168)) {
                MosWF_TypedDataContext12_ForReadOnly valDataContext168 = new MosWF_TypedDataContext12_ForReadOnly(locations, true);
                return valDataContext168.ValueType___Expr168Get();
            }
            if ((expressionId == 169)) {
                MosWF_TypedDataContext12 refDataContext169 = new MosWF_TypedDataContext12(locations, true);
                return refDataContext169.GetLocation<int>(refDataContext169.ValueType___Expr169Get, refDataContext169.ValueType___Expr169Set);
            }
            if ((expressionId == 170)) {
                MosWF_TypedDataContext12 refDataContext170 = new MosWF_TypedDataContext12(locations, true);
                return refDataContext170.GetLocation<int>(refDataContext170.ValueType___Expr170Get, refDataContext170.ValueType___Expr170Set);
            }
            if ((expressionId == 171)) {
                MosWF_TypedDataContext12 refDataContext171 = new MosWF_TypedDataContext12(locations, true);
                return refDataContext171.GetLocation<int>(refDataContext171.ValueType___Expr171Get, refDataContext171.ValueType___Expr171Set);
            }
            if ((expressionId == 172)) {
                MosWF_TypedDataContext12 refDataContext172 = new MosWF_TypedDataContext12(locations, true);
                return refDataContext172.GetLocation<int>(refDataContext172.ValueType___Expr172Get, refDataContext172.ValueType___Expr172Set);
            }
            if ((expressionId == 173)) {
                MosWF_TypedDataContext12_ForReadOnly valDataContext173 = new MosWF_TypedDataContext12_ForReadOnly(locations, true);
                return valDataContext173.ValueType___Expr173Get();
            }
            if ((expressionId == 174)) {
                MosWF_TypedDataContext12 refDataContext174 = new MosWF_TypedDataContext12(locations, true);
                return refDataContext174.GetLocation<int>(refDataContext174.ValueType___Expr174Get, refDataContext174.ValueType___Expr174Set);
            }
            if ((expressionId == 175)) {
                MosWF_TypedDataContext12 refDataContext175 = new MosWF_TypedDataContext12(locations, true);
                return refDataContext175.GetLocation<int>(refDataContext175.ValueType___Expr175Get, refDataContext175.ValueType___Expr175Set);
            }
            if ((expressionId == 176)) {
                MosWF_TypedDataContext12 refDataContext176 = new MosWF_TypedDataContext12(locations, true);
                return refDataContext176.GetLocation<int>(refDataContext176.ValueType___Expr176Get, refDataContext176.ValueType___Expr176Set);
            }
            if ((expressionId == 177)) {
                MosWF_TypedDataContext12 refDataContext177 = new MosWF_TypedDataContext12(locations, true);
                return refDataContext177.GetLocation<int>(refDataContext177.ValueType___Expr177Get, refDataContext177.ValueType___Expr177Set);
            }
            if ((expressionId == 178)) {
                MosWF_TypedDataContext12_ForReadOnly valDataContext178 = new MosWF_TypedDataContext12_ForReadOnly(locations, true);
                return valDataContext178.ValueType___Expr178Get();
            }
            if ((expressionId == 179)) {
                MosWF_TypedDataContext12_ForReadOnly valDataContext179 = new MosWF_TypedDataContext12_ForReadOnly(locations, true);
                return valDataContext179.ValueType___Expr179Get();
            }
            if ((expressionId == 180)) {
                MosWF_TypedDataContext13_ForReadOnly valDataContext180 = new MosWF_TypedDataContext13_ForReadOnly(locations, true);
                return valDataContext180.ValueType___Expr180Get();
            }
            if ((expressionId == 181)) {
                MosWF_TypedDataContext13 refDataContext181 = new MosWF_TypedDataContext13(locations, true);
                return refDataContext181.GetLocation<int>(refDataContext181.ValueType___Expr181Get, refDataContext181.ValueType___Expr181Set);
            }
            if ((expressionId == 182)) {
                MosWF_TypedDataContext13_ForReadOnly valDataContext182 = new MosWF_TypedDataContext13_ForReadOnly(locations, true);
                return valDataContext182.ValueType___Expr182Get();
            }
            if ((expressionId == 183)) {
                MosWF_TypedDataContext13 refDataContext183 = new MosWF_TypedDataContext13(locations, true);
                return refDataContext183.GetLocation<int>(refDataContext183.ValueType___Expr183Get, refDataContext183.ValueType___Expr183Set);
            }
            if ((expressionId == 184)) {
                MosWF_TypedDataContext13_ForReadOnly valDataContext184 = new MosWF_TypedDataContext13_ForReadOnly(locations, true);
                return valDataContext184.ValueType___Expr184Get();
            }
            if ((expressionId == 185)) {
                MosWF_TypedDataContext13 refDataContext185 = new MosWF_TypedDataContext13(locations, true);
                return refDataContext185.GetLocation<int>(refDataContext185.ValueType___Expr185Get, refDataContext185.ValueType___Expr185Set);
            }
            if ((expressionId == 186)) {
                MosWF_TypedDataContext13_ForReadOnly valDataContext186 = new MosWF_TypedDataContext13_ForReadOnly(locations, true);
                return valDataContext186.ValueType___Expr186Get();
            }
            if ((expressionId == 187)) {
                MosWF_TypedDataContext13 refDataContext187 = new MosWF_TypedDataContext13(locations, true);
                return refDataContext187.GetLocation<bool>(refDataContext187.ValueType___Expr187Get, refDataContext187.ValueType___Expr187Set);
            }
            if ((expressionId == 188)) {
                MosWF_TypedDataContext13_ForReadOnly valDataContext188 = new MosWF_TypedDataContext13_ForReadOnly(locations, true);
                return valDataContext188.ValueType___Expr188Get();
            }
            if ((expressionId == 189)) {
                MosWF_TypedDataContext13 refDataContext189 = new MosWF_TypedDataContext13(locations, true);
                return refDataContext189.GetLocation<bool>(refDataContext189.ValueType___Expr189Get, refDataContext189.ValueType___Expr189Set);
            }
            if ((expressionId == 190)) {
                MosWF_TypedDataContext13_ForReadOnly valDataContext190 = new MosWF_TypedDataContext13_ForReadOnly(locations, true);
                return valDataContext190.ValueType___Expr190Get();
            }
            if ((expressionId == 191)) {
                MosWF_TypedDataContext13 refDataContext191 = new MosWF_TypedDataContext13(locations, true);
                return refDataContext191.GetLocation<int>(refDataContext191.ValueType___Expr191Get, refDataContext191.ValueType___Expr191Set);
            }
            if ((expressionId == 192)) {
                MosWF_TypedDataContext14_ForReadOnly valDataContext192 = new MosWF_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext192.ValueType___Expr192Get();
            }
            if ((expressionId == 193)) {
                MosWF_TypedDataContext14_ForReadOnly valDataContext193 = new MosWF_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext193.ValueType___Expr193Get();
            }
            if ((expressionId == 194)) {
                MosWF_TypedDataContext14_ForReadOnly valDataContext194 = new MosWF_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext194.ValueType___Expr194Get();
            }
            if ((expressionId == 195)) {
                MosWF_TypedDataContext14 refDataContext195 = new MosWF_TypedDataContext14(locations, true);
                return refDataContext195.GetLocation<bool>(refDataContext195.ValueType___Expr195Get, refDataContext195.ValueType___Expr195Set);
            }
            if ((expressionId == 196)) {
                MosWF_TypedDataContext14 refDataContext196 = new MosWF_TypedDataContext14(locations, true);
                return refDataContext196.GetLocation<bool>(refDataContext196.ValueType___Expr196Get, refDataContext196.ValueType___Expr196Set);
            }
            if ((expressionId == 197)) {
                MosWF_TypedDataContext14 refDataContext197 = new MosWF_TypedDataContext14(locations, true);
                return refDataContext197.GetLocation<bool>(refDataContext197.ValueType___Expr197Get, refDataContext197.ValueType___Expr197Set);
            }
            if ((expressionId == 198)) {
                MosWF_TypedDataContext14 refDataContext198 = new MosWF_TypedDataContext14(locations, true);
                return refDataContext198.GetLocation<bool>(refDataContext198.ValueType___Expr198Get, refDataContext198.ValueType___Expr198Set);
            }
            if ((expressionId == 199)) {
                MosWF_TypedDataContext14_ForReadOnly valDataContext199 = new MosWF_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext199.ValueType___Expr199Get();
            }
            if ((expressionId == 200)) {
                MosWF_TypedDataContext14 refDataContext200 = new MosWF_TypedDataContext14(locations, true);
                return refDataContext200.GetLocation<int>(refDataContext200.ValueType___Expr200Get, refDataContext200.ValueType___Expr200Set);
            }
            if ((expressionId == 201)) {
                MosWF_TypedDataContext14 refDataContext201 = new MosWF_TypedDataContext14(locations, true);
                return refDataContext201.GetLocation<bool>(refDataContext201.ValueType___Expr201Get, refDataContext201.ValueType___Expr201Set);
            }
            if ((expressionId == 202)) {
                MosWF_TypedDataContext14 refDataContext202 = new MosWF_TypedDataContext14(locations, true);
                return refDataContext202.GetLocation<bool>(refDataContext202.ValueType___Expr202Get, refDataContext202.ValueType___Expr202Set);
            }
            if ((expressionId == 203)) {
                MosWF_TypedDataContext14 refDataContext203 = new MosWF_TypedDataContext14(locations, true);
                return refDataContext203.GetLocation<bool>(refDataContext203.ValueType___Expr203Get, refDataContext203.ValueType___Expr203Set);
            }
            if ((expressionId == 204)) {
                MosWF_TypedDataContext14 refDataContext204 = new MosWF_TypedDataContext14(locations, true);
                return refDataContext204.GetLocation<bool>(refDataContext204.ValueType___Expr204Get, refDataContext204.ValueType___Expr204Set);
            }
            if ((expressionId == 205)) {
                MosWF_TypedDataContext14 refDataContext205 = new MosWF_TypedDataContext14(locations, true);
                return refDataContext205.GetLocation<bool>(refDataContext205.ValueType___Expr205Get, refDataContext205.ValueType___Expr205Set);
            }
            if ((expressionId == 206)) {
                MosWF_TypedDataContext14_ForReadOnly valDataContext206 = new MosWF_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext206.ValueType___Expr206Get();
            }
            if ((expressionId == 207)) {
                MosWF_TypedDataContext14 refDataContext207 = new MosWF_TypedDataContext14(locations, true);
                return refDataContext207.GetLocation<int>(refDataContext207.ValueType___Expr207Get, refDataContext207.ValueType___Expr207Set);
            }
            if ((expressionId == 208)) {
                MosWF_TypedDataContext14 refDataContext208 = new MosWF_TypedDataContext14(locations, true);
                return refDataContext208.GetLocation<int>(refDataContext208.ValueType___Expr208Get, refDataContext208.ValueType___Expr208Set);
            }
            if ((expressionId == 209)) {
                MosWF_TypedDataContext14 refDataContext209 = new MosWF_TypedDataContext14(locations, true);
                return refDataContext209.GetLocation<int>(refDataContext209.ValueType___Expr209Get, refDataContext209.ValueType___Expr209Set);
            }
            if ((expressionId == 210)) {
                MosWF_TypedDataContext14 refDataContext210 = new MosWF_TypedDataContext14(locations, true);
                return refDataContext210.GetLocation<int>(refDataContext210.ValueType___Expr210Get, refDataContext210.ValueType___Expr210Set);
            }
            if ((expressionId == 211)) {
                MosWF_TypedDataContext14_ForReadOnly valDataContext211 = new MosWF_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext211.ValueType___Expr211Get();
            }
            if ((expressionId == 212)) {
                MosWF_TypedDataContext15 refDataContext212 = new MosWF_TypedDataContext15(locations, true);
                return refDataContext212.GetLocation<bool>(refDataContext212.ValueType___Expr212Get, refDataContext212.ValueType___Expr212Set);
            }
            if ((expressionId == 213)) {
                MosWF_TypedDataContext15 refDataContext213 = new MosWF_TypedDataContext15(locations, true);
                return refDataContext213.GetLocation<bool>(refDataContext213.ValueType___Expr213Get, refDataContext213.ValueType___Expr213Set);
            }
            if ((expressionId == 214)) {
                MosWF_TypedDataContext15_ForReadOnly valDataContext214 = new MosWF_TypedDataContext15_ForReadOnly(locations, true);
                return valDataContext214.ValueType___Expr214Get();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == true) 
                        && ((expressionText == "targetRole") 
                        && (MosWF_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetNextRole") 
                        && (MosWF_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetState") 
                        && (MosWF_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetFunction") 
                        && (MosWF_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "curState == 1") 
                        && (MosWF_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "curRole == targetRole") 
                        && (MosWF_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetEditMode") 
                        && (MosWF_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetEditMode") 
                        && (MosWF_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "isEnd") 
                        && (MosWF_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "isNext") 
                        && (MosWF_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetEditMode") 
                        && (MosWF_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "isEnd") 
                        && (MosWF_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "isNext") 
                        && (MosWF_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 12;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "isNext") 
                        && (MosWF_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 13;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetRole") 
                        && (MosWF_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 14;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetNextRole") 
                        && (MosWF_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 15;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetState") 
                        && (MosWF_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 16;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetFunction") 
                        && (MosWF_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 17;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "isEnd") 
                        && (MosWF_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 18;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "curState == 2") 
                        && (MosWF_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 19;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "curRole == targetRole") 
                        && (MosWF_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 20;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetEditMode") 
                        && (MosWF_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 21;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetEditMode") 
                        && (MosWF_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 22;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "isEnd") 
                        && (MosWF_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 23;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "isNext") 
                        && (MosWF_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 24;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetEditMode") 
                        && (MosWF_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 25;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "isEnd") 
                        && (MosWF_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 26;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "isNext") 
                        && (MosWF_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 27;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "isEnd") 
                        && (MosWF_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 28;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "isNext && curMode == 1") 
                        && (MosWF_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 29;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetRole") 
                        && (MosWF_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 30;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetNextRole") 
                        && (MosWF_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 31;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetState") 
                        && (MosWF_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 32;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetFunction") 
                        && (MosWF_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 33;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "isNext && curMode == 3") 
                        && (MosWF_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 34;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetRole") 
                        && (MosWF_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 35;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetNextRole") 
                        && (MosWF_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 36;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetState") 
                        && (MosWF_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 37;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetFunction") 
                        && (MosWF_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 38;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "isNext && curMode == 2") 
                        && (MosWF_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 39;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetRole") 
                        && (MosWF_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 40;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetNextRole") 
                        && (MosWF_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 41;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetState") 
                        && (MosWF_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 42;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetFunction") 
                        && (MosWF_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 43;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "curState == 6") 
                        && (MosWF_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 44;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "curRole == targetRole") 
                        && (MosWF_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 45;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "curMode == 2") 
                        && (MosWF_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 46;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetEditMode") 
                        && (MosWF_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 47;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetNeedAction") 
                        && (MosWF_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 48;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetEditMode") 
                        && (MosWF_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 49;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetEditMode") 
                        && (MosWF_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 50;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "isEnd") 
                        && (MosWF_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 51;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "isNext") 
                        && (MosWF_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 52;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetEditMode") 
                        && (MosWF_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 53;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "isEnd") 
                        && (MosWF_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 54;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "isNext") 
                        && (MosWF_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 55;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "isEnd") 
                        && (MosWF_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 56;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "isNext && (curMode == 1 || curMode == 2)") 
                        && (MosWF_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 57;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetRole") 
                        && (MosWF_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 58;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetNextRole") 
                        && (MosWF_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 59;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetState") 
                        && (MosWF_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 60;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetFunction") 
                        && (MosWF_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 61;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "curState == 3") 
                        && (MosWF_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 62;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "curRole == targetRole") 
                        && (MosWF_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 63;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "curMode == 1 || curMode == 2") 
                        && (MosWF_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 64;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetEditMode") 
                        && (MosWF_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 65;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetNeedAction") 
                        && (MosWF_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 66;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetEditMode") 
                        && (MosWF_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 67;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetEditMode") 
                        && (MosWF_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 68;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "isEnd") 
                        && (MosWF_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 69;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "isNext") 
                        && (MosWF_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 70;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetEditMode") 
                        && (MosWF_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 71;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "isEnd") 
                        && (MosWF_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 72;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "isNext") 
                        && (MosWF_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 73;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "isEnd") 
                        && (MosWF_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 74;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "isNext && curMode == 1") 
                        && (MosWF_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 75;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetRole") 
                        && (MosWF_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 76;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetNextRole") 
                        && (MosWF_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 77;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetState") 
                        && (MosWF_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 78;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetFunction") 
                        && (MosWF_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 79;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "isNext && curMode == 2") 
                        && (MosWF_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 80;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetRole") 
                        && (MosWF_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 81;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetNextRole") 
                        && (MosWF_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 82;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetState") 
                        && (MosWF_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 83;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetFunction") 
                        && (MosWF_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 84;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "curState == 5") 
                        && (MosWF_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 85;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "curRole == targetRole") 
                        && (MosWF_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 86;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "curMode == 1 || curMode == 2") 
                        && (MosWF_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 87;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetEditMode") 
                        && (MosWF_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 88;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetNeedAction") 
                        && (MosWF_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 89;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetEditMode") 
                        && (MosWF_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 90;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetEditMode") 
                        && (MosWF_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 91;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "isEnd") 
                        && (MosWF_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 92;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "isNext") 
                        && (MosWF_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 93;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetEditMode") 
                        && (MosWF_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 94;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "isEnd") 
                        && (MosWF_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 95;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "isNext") 
                        && (MosWF_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 96;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "isNext && curMode == 3") 
                        && (MosWF_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 97;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetRole") 
                        && (MosWF_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 98;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetNextRole") 
                        && (MosWF_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 99;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetState") 
                        && (MosWF_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 100;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetFunction") 
                        && (MosWF_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 101;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "isNext && curMode == 2 && extCount < 2") 
                        && (MosWF_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 102;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetRole") 
                        && (MosWF_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 103;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetNextRole") 
                        && (MosWF_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 104;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetState") 
                        && (MosWF_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 105;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetFunction") 
                        && (MosWF_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 106;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "isEnd") 
                        && (MosWF_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 107;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "curState == 4") 
                        && (MosWF_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 108;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "curRole == targetRole") 
                        && (MosWF_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 109;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "curMode == 1 || curMode == 2") 
                        && (MosWF_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 110;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetEditMode") 
                        && (MosWF_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 111;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetNeedAction") 
                        && (MosWF_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 112;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetEditMode") 
                        && (MosWF_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 113;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetEditMode") 
                        && (MosWF_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 114;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "isEnd") 
                        && (MosWF_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 115;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "isNext") 
                        && (MosWF_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 116;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetEditMode") 
                        && (MosWF_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 117;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "isEnd") 
                        && (MosWF_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 118;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "isNext") 
                        && (MosWF_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 119;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "isNext && curMode == 1") 
                        && (MosWF_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 120;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetFunction") 
                        && (MosWF_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 121;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "isEnd") 
                        && (MosWF_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 122;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "isNext && curMode == 3") 
                        && (MosWF_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 123;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetRole") 
                        && (MosWF_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 124;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetNextRole") 
                        && (MosWF_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 125;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetState") 
                        && (MosWF_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 126;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetFunction") 
                        && (MosWF_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 127;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "isNext && curMode == 2") 
                        && (MosWF_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 128;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "extCount < 2") 
                        && (MosWF_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 129;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetFunction") 
                        && (MosWF_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 130;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetRole") 
                        && (MosWF_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 131;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetNextRole") 
                        && (MosWF_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 132;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetState") 
                        && (MosWF_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 133;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetFunction") 
                        && (MosWF_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 134;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "isNext && curMode == 3") 
                        && (MosWF_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 135;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetFunction") 
                        && (MosWF_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 136;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "curState == 7") 
                        && (MosWF_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 137;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "curRole == targetRole") 
                        && (MosWF_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 138;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetEditMode") 
                        && (MosWF_TypedDataContext10.Validate(locations, true, 0) == true)))) {
                expressionId = 139;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetEditMode") 
                        && (MosWF_TypedDataContext10.Validate(locations, true, 0) == true)))) {
                expressionId = 140;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "isEnd") 
                        && (MosWF_TypedDataContext10.Validate(locations, true, 0) == true)))) {
                expressionId = 141;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "isNext") 
                        && (MosWF_TypedDataContext10.Validate(locations, true, 0) == true)))) {
                expressionId = 142;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetEditMode") 
                        && (MosWF_TypedDataContext10.Validate(locations, true, 0) == true)))) {
                expressionId = 143;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "isEnd") 
                        && (MosWF_TypedDataContext10.Validate(locations, true, 0) == true)))) {
                expressionId = 144;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "isNext") 
                        && (MosWF_TypedDataContext10.Validate(locations, true, 0) == true)))) {
                expressionId = 145;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "isNext && curMode == 2") 
                        && (MosWF_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 146;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetRole") 
                        && (MosWF_TypedDataContext10.Validate(locations, true, 0) == true)))) {
                expressionId = 147;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetNextRole") 
                        && (MosWF_TypedDataContext10.Validate(locations, true, 0) == true)))) {
                expressionId = 148;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetState") 
                        && (MosWF_TypedDataContext10.Validate(locations, true, 0) == true)))) {
                expressionId = 149;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetFunction") 
                        && (MosWF_TypedDataContext10.Validate(locations, true, 0) == true)))) {
                expressionId = 150;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "isEnd") 
                        && (MosWF_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 151;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "curState == 9") 
                        && (MosWF_TypedDataContext11_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 152;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "curRole == targetRole") 
                        && (MosWF_TypedDataContext11_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 153;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetEditMode") 
                        && (MosWF_TypedDataContext11.Validate(locations, true, 0) == true)))) {
                expressionId = 154;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetEditMode") 
                        && (MosWF_TypedDataContext11.Validate(locations, true, 0) == true)))) {
                expressionId = 155;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "isEnd") 
                        && (MosWF_TypedDataContext11.Validate(locations, true, 0) == true)))) {
                expressionId = 156;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "isNext") 
                        && (MosWF_TypedDataContext11.Validate(locations, true, 0) == true)))) {
                expressionId = 157;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetEditMode") 
                        && (MosWF_TypedDataContext11.Validate(locations, true, 0) == true)))) {
                expressionId = 158;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "isEnd") 
                        && (MosWF_TypedDataContext11.Validate(locations, true, 0) == true)))) {
                expressionId = 159;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "isNext") 
                        && (MosWF_TypedDataContext11.Validate(locations, true, 0) == true)))) {
                expressionId = 160;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "isNext && curMode == 3") 
                        && (MosWF_TypedDataContext11_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 161;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetRole") 
                        && (MosWF_TypedDataContext11.Validate(locations, true, 0) == true)))) {
                expressionId = 162;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetNextRole") 
                        && (MosWF_TypedDataContext11.Validate(locations, true, 0) == true)))) {
                expressionId = 163;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetState") 
                        && (MosWF_TypedDataContext11.Validate(locations, true, 0) == true)))) {
                expressionId = 164;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetFunction") 
                        && (MosWF_TypedDataContext11.Validate(locations, true, 0) == true)))) {
                expressionId = 165;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "isEnd") 
                        && (MosWF_TypedDataContext11_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 166;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "curMode == 1") 
                        && (MosWF_TypedDataContext12_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 167;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "curMode == 3 && curState != 11") 
                        && (MosWF_TypedDataContext12_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 168;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetRole") 
                        && (MosWF_TypedDataContext12.Validate(locations, true, 0) == true)))) {
                expressionId = 169;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetNextRole") 
                        && (MosWF_TypedDataContext12.Validate(locations, true, 0) == true)))) {
                expressionId = 170;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetState") 
                        && (MosWF_TypedDataContext12.Validate(locations, true, 0) == true)))) {
                expressionId = 171;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetFunction") 
                        && (MosWF_TypedDataContext12.Validate(locations, true, 0) == true)))) {
                expressionId = 172;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "curMode == 2") 
                        && (MosWF_TypedDataContext12_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 173;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetRole") 
                        && (MosWF_TypedDataContext12.Validate(locations, true, 0) == true)))) {
                expressionId = 174;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetNextRole") 
                        && (MosWF_TypedDataContext12.Validate(locations, true, 0) == true)))) {
                expressionId = 175;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetState") 
                        && (MosWF_TypedDataContext12.Validate(locations, true, 0) == true)))) {
                expressionId = 176;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetFunction") 
                        && (MosWF_TypedDataContext12.Validate(locations, true, 0) == true)))) {
                expressionId = 177;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "curMode == 4 || (curMode == 3 && curState == 11)") 
                        && (MosWF_TypedDataContext12_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 178;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "curMode < 1 || curMode > 4") 
                        && (MosWF_TypedDataContext12_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 179;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "targetNextRole") 
                        && (MosWF_TypedDataContext13_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 180;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "nextRole") 
                        && (MosWF_TypedDataContext13.Validate(locations, true, 0) == true)))) {
                expressionId = 181;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "targetState") 
                        && (MosWF_TypedDataContext13_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 182;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "nextState") 
                        && (MosWF_TypedDataContext13.Validate(locations, true, 0) == true)))) {
                expressionId = 183;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "targetFunction") 
                        && (MosWF_TypedDataContext13_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 184;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "nextFunction") 
                        && (MosWF_TypedDataContext13.Validate(locations, true, 0) == true)))) {
                expressionId = 185;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "targetEditMode") 
                        && (MosWF_TypedDataContext13_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 186;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "isEditMode") 
                        && (MosWF_TypedDataContext13.Validate(locations, true, 0) == true)))) {
                expressionId = 187;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "targetNeedAction") 
                        && (MosWF_TypedDataContext13_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 188;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "isNeedAction") 
                        && (MosWF_TypedDataContext13.Validate(locations, true, 0) == true)))) {
                expressionId = 189;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "extCount") 
                        && (MosWF_TypedDataContext13_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 190;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "nextCount") 
                        && (MosWF_TypedDataContext13.Validate(locations, true, 0) == true)))) {
                expressionId = 191;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "curState == 8") 
                        && (MosWF_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 192;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "curRole == targetRole") 
                        && (MosWF_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 193;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "curMode == 2") 
                        && (MosWF_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 194;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetEditMode") 
                        && (MosWF_TypedDataContext14.Validate(locations, true, 0) == true)))) {
                expressionId = 195;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetNeedAction") 
                        && (MosWF_TypedDataContext14.Validate(locations, true, 0) == true)))) {
                expressionId = 196;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetEditMode") 
                        && (MosWF_TypedDataContext14.Validate(locations, true, 0) == true)))) {
                expressionId = 197;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetEditMode") 
                        && (MosWF_TypedDataContext14.Validate(locations, true, 0) == true)))) {
                expressionId = 198;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "extCount + 1") 
                        && (MosWF_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 199;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "extCount") 
                        && (MosWF_TypedDataContext14.Validate(locations, true, 0) == true)))) {
                expressionId = 200;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "isEnd") 
                        && (MosWF_TypedDataContext14.Validate(locations, true, 0) == true)))) {
                expressionId = 201;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "isNext") 
                        && (MosWF_TypedDataContext14.Validate(locations, true, 0) == true)))) {
                expressionId = 202;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetEditMode") 
                        && (MosWF_TypedDataContext14.Validate(locations, true, 0) == true)))) {
                expressionId = 203;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "isEnd") 
                        && (MosWF_TypedDataContext14.Validate(locations, true, 0) == true)))) {
                expressionId = 204;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "isNext") 
                        && (MosWF_TypedDataContext14.Validate(locations, true, 0) == true)))) {
                expressionId = 205;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "isNext && curMode == 2") 
                        && (MosWF_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 206;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetRole") 
                        && (MosWF_TypedDataContext14.Validate(locations, true, 0) == true)))) {
                expressionId = 207;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetNextRole") 
                        && (MosWF_TypedDataContext14.Validate(locations, true, 0) == true)))) {
                expressionId = 208;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetState") 
                        && (MosWF_TypedDataContext14.Validate(locations, true, 0) == true)))) {
                expressionId = 209;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetFunction") 
                        && (MosWF_TypedDataContext14.Validate(locations, true, 0) == true)))) {
                expressionId = 210;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "isEnd") 
                        && (MosWF_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 211;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "targetEditMode") 
                        && (MosWF_TypedDataContext15.Validate(locations, true, 0) == true)))) {
                expressionId = 212;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "isEnd") 
                        && (MosWF_TypedDataContext15.Validate(locations, true, 0) == true)))) {
                expressionId = 213;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "isEnd") 
                        && (MosWF_TypedDataContext15_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 214;
                return true;
            }
            expressionId = -1;
            return false;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Collections.Generic.IList<string> GetRequiredLocations(int expressionId) {
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Linq.Expressions.Expression GetExpressionTreeForExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) {
            if ((expressionId == 0)) {
                return new MosWF_TypedDataContext3(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new MosWF_TypedDataContext3(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new MosWF_TypedDataContext3(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new MosWF_TypedDataContext3(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new MosWF_TypedDataContext4_ForReadOnly(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new MosWF_TypedDataContext4_ForReadOnly(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new MosWF_TypedDataContext4(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new MosWF_TypedDataContext4(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new MosWF_TypedDataContext4(locationReferences).@__Expr8GetTree();
            }
            if ((expressionId == 9)) {
                return new MosWF_TypedDataContext4(locationReferences).@__Expr9GetTree();
            }
            if ((expressionId == 10)) {
                return new MosWF_TypedDataContext4(locationReferences).@__Expr10GetTree();
            }
            if ((expressionId == 11)) {
                return new MosWF_TypedDataContext4(locationReferences).@__Expr11GetTree();
            }
            if ((expressionId == 12)) {
                return new MosWF_TypedDataContext4(locationReferences).@__Expr12GetTree();
            }
            if ((expressionId == 13)) {
                return new MosWF_TypedDataContext4_ForReadOnly(locationReferences).@__Expr13GetTree();
            }
            if ((expressionId == 14)) {
                return new MosWF_TypedDataContext4(locationReferences).@__Expr14GetTree();
            }
            if ((expressionId == 15)) {
                return new MosWF_TypedDataContext4(locationReferences).@__Expr15GetTree();
            }
            if ((expressionId == 16)) {
                return new MosWF_TypedDataContext4(locationReferences).@__Expr16GetTree();
            }
            if ((expressionId == 17)) {
                return new MosWF_TypedDataContext4(locationReferences).@__Expr17GetTree();
            }
            if ((expressionId == 18)) {
                return new MosWF_TypedDataContext4_ForReadOnly(locationReferences).@__Expr18GetTree();
            }
            if ((expressionId == 19)) {
                return new MosWF_TypedDataContext5_ForReadOnly(locationReferences).@__Expr19GetTree();
            }
            if ((expressionId == 20)) {
                return new MosWF_TypedDataContext5_ForReadOnly(locationReferences).@__Expr20GetTree();
            }
            if ((expressionId == 21)) {
                return new MosWF_TypedDataContext5(locationReferences).@__Expr21GetTree();
            }
            if ((expressionId == 22)) {
                return new MosWF_TypedDataContext5(locationReferences).@__Expr22GetTree();
            }
            if ((expressionId == 23)) {
                return new MosWF_TypedDataContext5(locationReferences).@__Expr23GetTree();
            }
            if ((expressionId == 24)) {
                return new MosWF_TypedDataContext5(locationReferences).@__Expr24GetTree();
            }
            if ((expressionId == 25)) {
                return new MosWF_TypedDataContext5(locationReferences).@__Expr25GetTree();
            }
            if ((expressionId == 26)) {
                return new MosWF_TypedDataContext5(locationReferences).@__Expr26GetTree();
            }
            if ((expressionId == 27)) {
                return new MosWF_TypedDataContext5(locationReferences).@__Expr27GetTree();
            }
            if ((expressionId == 28)) {
                return new MosWF_TypedDataContext5_ForReadOnly(locationReferences).@__Expr28GetTree();
            }
            if ((expressionId == 29)) {
                return new MosWF_TypedDataContext5_ForReadOnly(locationReferences).@__Expr29GetTree();
            }
            if ((expressionId == 30)) {
                return new MosWF_TypedDataContext5(locationReferences).@__Expr30GetTree();
            }
            if ((expressionId == 31)) {
                return new MosWF_TypedDataContext5(locationReferences).@__Expr31GetTree();
            }
            if ((expressionId == 32)) {
                return new MosWF_TypedDataContext5(locationReferences).@__Expr32GetTree();
            }
            if ((expressionId == 33)) {
                return new MosWF_TypedDataContext5(locationReferences).@__Expr33GetTree();
            }
            if ((expressionId == 34)) {
                return new MosWF_TypedDataContext5_ForReadOnly(locationReferences).@__Expr34GetTree();
            }
            if ((expressionId == 35)) {
                return new MosWF_TypedDataContext5(locationReferences).@__Expr35GetTree();
            }
            if ((expressionId == 36)) {
                return new MosWF_TypedDataContext5(locationReferences).@__Expr36GetTree();
            }
            if ((expressionId == 37)) {
                return new MosWF_TypedDataContext5(locationReferences).@__Expr37GetTree();
            }
            if ((expressionId == 38)) {
                return new MosWF_TypedDataContext5(locationReferences).@__Expr38GetTree();
            }
            if ((expressionId == 39)) {
                return new MosWF_TypedDataContext5_ForReadOnly(locationReferences).@__Expr39GetTree();
            }
            if ((expressionId == 40)) {
                return new MosWF_TypedDataContext5(locationReferences).@__Expr40GetTree();
            }
            if ((expressionId == 41)) {
                return new MosWF_TypedDataContext5(locationReferences).@__Expr41GetTree();
            }
            if ((expressionId == 42)) {
                return new MosWF_TypedDataContext5(locationReferences).@__Expr42GetTree();
            }
            if ((expressionId == 43)) {
                return new MosWF_TypedDataContext5(locationReferences).@__Expr43GetTree();
            }
            if ((expressionId == 44)) {
                return new MosWF_TypedDataContext6_ForReadOnly(locationReferences).@__Expr44GetTree();
            }
            if ((expressionId == 45)) {
                return new MosWF_TypedDataContext6_ForReadOnly(locationReferences).@__Expr45GetTree();
            }
            if ((expressionId == 46)) {
                return new MosWF_TypedDataContext6_ForReadOnly(locationReferences).@__Expr46GetTree();
            }
            if ((expressionId == 47)) {
                return new MosWF_TypedDataContext6(locationReferences).@__Expr47GetTree();
            }
            if ((expressionId == 48)) {
                return new MosWF_TypedDataContext6(locationReferences).@__Expr48GetTree();
            }
            if ((expressionId == 49)) {
                return new MosWF_TypedDataContext6(locationReferences).@__Expr49GetTree();
            }
            if ((expressionId == 50)) {
                return new MosWF_TypedDataContext6(locationReferences).@__Expr50GetTree();
            }
            if ((expressionId == 51)) {
                return new MosWF_TypedDataContext6(locationReferences).@__Expr51GetTree();
            }
            if ((expressionId == 52)) {
                return new MosWF_TypedDataContext6(locationReferences).@__Expr52GetTree();
            }
            if ((expressionId == 53)) {
                return new MosWF_TypedDataContext6(locationReferences).@__Expr53GetTree();
            }
            if ((expressionId == 54)) {
                return new MosWF_TypedDataContext6(locationReferences).@__Expr54GetTree();
            }
            if ((expressionId == 55)) {
                return new MosWF_TypedDataContext6(locationReferences).@__Expr55GetTree();
            }
            if ((expressionId == 56)) {
                return new MosWF_TypedDataContext6_ForReadOnly(locationReferences).@__Expr56GetTree();
            }
            if ((expressionId == 57)) {
                return new MosWF_TypedDataContext6_ForReadOnly(locationReferences).@__Expr57GetTree();
            }
            if ((expressionId == 58)) {
                return new MosWF_TypedDataContext6(locationReferences).@__Expr58GetTree();
            }
            if ((expressionId == 59)) {
                return new MosWF_TypedDataContext6(locationReferences).@__Expr59GetTree();
            }
            if ((expressionId == 60)) {
                return new MosWF_TypedDataContext6(locationReferences).@__Expr60GetTree();
            }
            if ((expressionId == 61)) {
                return new MosWF_TypedDataContext6(locationReferences).@__Expr61GetTree();
            }
            if ((expressionId == 62)) {
                return new MosWF_TypedDataContext7_ForReadOnly(locationReferences).@__Expr62GetTree();
            }
            if ((expressionId == 63)) {
                return new MosWF_TypedDataContext7_ForReadOnly(locationReferences).@__Expr63GetTree();
            }
            if ((expressionId == 64)) {
                return new MosWF_TypedDataContext7_ForReadOnly(locationReferences).@__Expr64GetTree();
            }
            if ((expressionId == 65)) {
                return new MosWF_TypedDataContext7(locationReferences).@__Expr65GetTree();
            }
            if ((expressionId == 66)) {
                return new MosWF_TypedDataContext7(locationReferences).@__Expr66GetTree();
            }
            if ((expressionId == 67)) {
                return new MosWF_TypedDataContext7(locationReferences).@__Expr67GetTree();
            }
            if ((expressionId == 68)) {
                return new MosWF_TypedDataContext7(locationReferences).@__Expr68GetTree();
            }
            if ((expressionId == 69)) {
                return new MosWF_TypedDataContext7(locationReferences).@__Expr69GetTree();
            }
            if ((expressionId == 70)) {
                return new MosWF_TypedDataContext7(locationReferences).@__Expr70GetTree();
            }
            if ((expressionId == 71)) {
                return new MosWF_TypedDataContext7(locationReferences).@__Expr71GetTree();
            }
            if ((expressionId == 72)) {
                return new MosWF_TypedDataContext7(locationReferences).@__Expr72GetTree();
            }
            if ((expressionId == 73)) {
                return new MosWF_TypedDataContext7(locationReferences).@__Expr73GetTree();
            }
            if ((expressionId == 74)) {
                return new MosWF_TypedDataContext7_ForReadOnly(locationReferences).@__Expr74GetTree();
            }
            if ((expressionId == 75)) {
                return new MosWF_TypedDataContext7_ForReadOnly(locationReferences).@__Expr75GetTree();
            }
            if ((expressionId == 76)) {
                return new MosWF_TypedDataContext7(locationReferences).@__Expr76GetTree();
            }
            if ((expressionId == 77)) {
                return new MosWF_TypedDataContext7(locationReferences).@__Expr77GetTree();
            }
            if ((expressionId == 78)) {
                return new MosWF_TypedDataContext7(locationReferences).@__Expr78GetTree();
            }
            if ((expressionId == 79)) {
                return new MosWF_TypedDataContext7(locationReferences).@__Expr79GetTree();
            }
            if ((expressionId == 80)) {
                return new MosWF_TypedDataContext7_ForReadOnly(locationReferences).@__Expr80GetTree();
            }
            if ((expressionId == 81)) {
                return new MosWF_TypedDataContext7(locationReferences).@__Expr81GetTree();
            }
            if ((expressionId == 82)) {
                return new MosWF_TypedDataContext7(locationReferences).@__Expr82GetTree();
            }
            if ((expressionId == 83)) {
                return new MosWF_TypedDataContext7(locationReferences).@__Expr83GetTree();
            }
            if ((expressionId == 84)) {
                return new MosWF_TypedDataContext7(locationReferences).@__Expr84GetTree();
            }
            if ((expressionId == 85)) {
                return new MosWF_TypedDataContext8_ForReadOnly(locationReferences).@__Expr85GetTree();
            }
            if ((expressionId == 86)) {
                return new MosWF_TypedDataContext8_ForReadOnly(locationReferences).@__Expr86GetTree();
            }
            if ((expressionId == 87)) {
                return new MosWF_TypedDataContext8_ForReadOnly(locationReferences).@__Expr87GetTree();
            }
            if ((expressionId == 88)) {
                return new MosWF_TypedDataContext8(locationReferences).@__Expr88GetTree();
            }
            if ((expressionId == 89)) {
                return new MosWF_TypedDataContext8(locationReferences).@__Expr89GetTree();
            }
            if ((expressionId == 90)) {
                return new MosWF_TypedDataContext8(locationReferences).@__Expr90GetTree();
            }
            if ((expressionId == 91)) {
                return new MosWF_TypedDataContext8(locationReferences).@__Expr91GetTree();
            }
            if ((expressionId == 92)) {
                return new MosWF_TypedDataContext8(locationReferences).@__Expr92GetTree();
            }
            if ((expressionId == 93)) {
                return new MosWF_TypedDataContext8(locationReferences).@__Expr93GetTree();
            }
            if ((expressionId == 94)) {
                return new MosWF_TypedDataContext8(locationReferences).@__Expr94GetTree();
            }
            if ((expressionId == 95)) {
                return new MosWF_TypedDataContext8(locationReferences).@__Expr95GetTree();
            }
            if ((expressionId == 96)) {
                return new MosWF_TypedDataContext8(locationReferences).@__Expr96GetTree();
            }
            if ((expressionId == 97)) {
                return new MosWF_TypedDataContext8_ForReadOnly(locationReferences).@__Expr97GetTree();
            }
            if ((expressionId == 98)) {
                return new MosWF_TypedDataContext8(locationReferences).@__Expr98GetTree();
            }
            if ((expressionId == 99)) {
                return new MosWF_TypedDataContext8(locationReferences).@__Expr99GetTree();
            }
            if ((expressionId == 100)) {
                return new MosWF_TypedDataContext8(locationReferences).@__Expr100GetTree();
            }
            if ((expressionId == 101)) {
                return new MosWF_TypedDataContext8(locationReferences).@__Expr101GetTree();
            }
            if ((expressionId == 102)) {
                return new MosWF_TypedDataContext8_ForReadOnly(locationReferences).@__Expr102GetTree();
            }
            if ((expressionId == 103)) {
                return new MosWF_TypedDataContext8(locationReferences).@__Expr103GetTree();
            }
            if ((expressionId == 104)) {
                return new MosWF_TypedDataContext8(locationReferences).@__Expr104GetTree();
            }
            if ((expressionId == 105)) {
                return new MosWF_TypedDataContext8(locationReferences).@__Expr105GetTree();
            }
            if ((expressionId == 106)) {
                return new MosWF_TypedDataContext8(locationReferences).@__Expr106GetTree();
            }
            if ((expressionId == 107)) {
                return new MosWF_TypedDataContext8_ForReadOnly(locationReferences).@__Expr107GetTree();
            }
            if ((expressionId == 108)) {
                return new MosWF_TypedDataContext9_ForReadOnly(locationReferences).@__Expr108GetTree();
            }
            if ((expressionId == 109)) {
                return new MosWF_TypedDataContext9_ForReadOnly(locationReferences).@__Expr109GetTree();
            }
            if ((expressionId == 110)) {
                return new MosWF_TypedDataContext9_ForReadOnly(locationReferences).@__Expr110GetTree();
            }
            if ((expressionId == 111)) {
                return new MosWF_TypedDataContext9(locationReferences).@__Expr111GetTree();
            }
            if ((expressionId == 112)) {
                return new MosWF_TypedDataContext9(locationReferences).@__Expr112GetTree();
            }
            if ((expressionId == 113)) {
                return new MosWF_TypedDataContext9(locationReferences).@__Expr113GetTree();
            }
            if ((expressionId == 114)) {
                return new MosWF_TypedDataContext9(locationReferences).@__Expr114GetTree();
            }
            if ((expressionId == 115)) {
                return new MosWF_TypedDataContext9(locationReferences).@__Expr115GetTree();
            }
            if ((expressionId == 116)) {
                return new MosWF_TypedDataContext9(locationReferences).@__Expr116GetTree();
            }
            if ((expressionId == 117)) {
                return new MosWF_TypedDataContext9(locationReferences).@__Expr117GetTree();
            }
            if ((expressionId == 118)) {
                return new MosWF_TypedDataContext9(locationReferences).@__Expr118GetTree();
            }
            if ((expressionId == 119)) {
                return new MosWF_TypedDataContext9(locationReferences).@__Expr119GetTree();
            }
            if ((expressionId == 120)) {
                return new MosWF_TypedDataContext9_ForReadOnly(locationReferences).@__Expr120GetTree();
            }
            if ((expressionId == 121)) {
                return new MosWF_TypedDataContext9(locationReferences).@__Expr121GetTree();
            }
            if ((expressionId == 122)) {
                return new MosWF_TypedDataContext9_ForReadOnly(locationReferences).@__Expr122GetTree();
            }
            if ((expressionId == 123)) {
                return new MosWF_TypedDataContext9_ForReadOnly(locationReferences).@__Expr123GetTree();
            }
            if ((expressionId == 124)) {
                return new MosWF_TypedDataContext9(locationReferences).@__Expr124GetTree();
            }
            if ((expressionId == 125)) {
                return new MosWF_TypedDataContext9(locationReferences).@__Expr125GetTree();
            }
            if ((expressionId == 126)) {
                return new MosWF_TypedDataContext9(locationReferences).@__Expr126GetTree();
            }
            if ((expressionId == 127)) {
                return new MosWF_TypedDataContext9(locationReferences).@__Expr127GetTree();
            }
            if ((expressionId == 128)) {
                return new MosWF_TypedDataContext9_ForReadOnly(locationReferences).@__Expr128GetTree();
            }
            if ((expressionId == 129)) {
                return new MosWF_TypedDataContext9_ForReadOnly(locationReferences).@__Expr129GetTree();
            }
            if ((expressionId == 130)) {
                return new MosWF_TypedDataContext9(locationReferences).@__Expr130GetTree();
            }
            if ((expressionId == 131)) {
                return new MosWF_TypedDataContext9(locationReferences).@__Expr131GetTree();
            }
            if ((expressionId == 132)) {
                return new MosWF_TypedDataContext9(locationReferences).@__Expr132GetTree();
            }
            if ((expressionId == 133)) {
                return new MosWF_TypedDataContext9(locationReferences).@__Expr133GetTree();
            }
            if ((expressionId == 134)) {
                return new MosWF_TypedDataContext9(locationReferences).@__Expr134GetTree();
            }
            if ((expressionId == 135)) {
                return new MosWF_TypedDataContext9_ForReadOnly(locationReferences).@__Expr135GetTree();
            }
            if ((expressionId == 136)) {
                return new MosWF_TypedDataContext9(locationReferences).@__Expr136GetTree();
            }
            if ((expressionId == 137)) {
                return new MosWF_TypedDataContext10_ForReadOnly(locationReferences).@__Expr137GetTree();
            }
            if ((expressionId == 138)) {
                return new MosWF_TypedDataContext10_ForReadOnly(locationReferences).@__Expr138GetTree();
            }
            if ((expressionId == 139)) {
                return new MosWF_TypedDataContext10(locationReferences).@__Expr139GetTree();
            }
            if ((expressionId == 140)) {
                return new MosWF_TypedDataContext10(locationReferences).@__Expr140GetTree();
            }
            if ((expressionId == 141)) {
                return new MosWF_TypedDataContext10(locationReferences).@__Expr141GetTree();
            }
            if ((expressionId == 142)) {
                return new MosWF_TypedDataContext10(locationReferences).@__Expr142GetTree();
            }
            if ((expressionId == 143)) {
                return new MosWF_TypedDataContext10(locationReferences).@__Expr143GetTree();
            }
            if ((expressionId == 144)) {
                return new MosWF_TypedDataContext10(locationReferences).@__Expr144GetTree();
            }
            if ((expressionId == 145)) {
                return new MosWF_TypedDataContext10(locationReferences).@__Expr145GetTree();
            }
            if ((expressionId == 146)) {
                return new MosWF_TypedDataContext10_ForReadOnly(locationReferences).@__Expr146GetTree();
            }
            if ((expressionId == 147)) {
                return new MosWF_TypedDataContext10(locationReferences).@__Expr147GetTree();
            }
            if ((expressionId == 148)) {
                return new MosWF_TypedDataContext10(locationReferences).@__Expr148GetTree();
            }
            if ((expressionId == 149)) {
                return new MosWF_TypedDataContext10(locationReferences).@__Expr149GetTree();
            }
            if ((expressionId == 150)) {
                return new MosWF_TypedDataContext10(locationReferences).@__Expr150GetTree();
            }
            if ((expressionId == 151)) {
                return new MosWF_TypedDataContext10_ForReadOnly(locationReferences).@__Expr151GetTree();
            }
            if ((expressionId == 152)) {
                return new MosWF_TypedDataContext11_ForReadOnly(locationReferences).@__Expr152GetTree();
            }
            if ((expressionId == 153)) {
                return new MosWF_TypedDataContext11_ForReadOnly(locationReferences).@__Expr153GetTree();
            }
            if ((expressionId == 154)) {
                return new MosWF_TypedDataContext11(locationReferences).@__Expr154GetTree();
            }
            if ((expressionId == 155)) {
                return new MosWF_TypedDataContext11(locationReferences).@__Expr155GetTree();
            }
            if ((expressionId == 156)) {
                return new MosWF_TypedDataContext11(locationReferences).@__Expr156GetTree();
            }
            if ((expressionId == 157)) {
                return new MosWF_TypedDataContext11(locationReferences).@__Expr157GetTree();
            }
            if ((expressionId == 158)) {
                return new MosWF_TypedDataContext11(locationReferences).@__Expr158GetTree();
            }
            if ((expressionId == 159)) {
                return new MosWF_TypedDataContext11(locationReferences).@__Expr159GetTree();
            }
            if ((expressionId == 160)) {
                return new MosWF_TypedDataContext11(locationReferences).@__Expr160GetTree();
            }
            if ((expressionId == 161)) {
                return new MosWF_TypedDataContext11_ForReadOnly(locationReferences).@__Expr161GetTree();
            }
            if ((expressionId == 162)) {
                return new MosWF_TypedDataContext11(locationReferences).@__Expr162GetTree();
            }
            if ((expressionId == 163)) {
                return new MosWF_TypedDataContext11(locationReferences).@__Expr163GetTree();
            }
            if ((expressionId == 164)) {
                return new MosWF_TypedDataContext11(locationReferences).@__Expr164GetTree();
            }
            if ((expressionId == 165)) {
                return new MosWF_TypedDataContext11(locationReferences).@__Expr165GetTree();
            }
            if ((expressionId == 166)) {
                return new MosWF_TypedDataContext11_ForReadOnly(locationReferences).@__Expr166GetTree();
            }
            if ((expressionId == 167)) {
                return new MosWF_TypedDataContext12_ForReadOnly(locationReferences).@__Expr167GetTree();
            }
            if ((expressionId == 168)) {
                return new MosWF_TypedDataContext12_ForReadOnly(locationReferences).@__Expr168GetTree();
            }
            if ((expressionId == 169)) {
                return new MosWF_TypedDataContext12(locationReferences).@__Expr169GetTree();
            }
            if ((expressionId == 170)) {
                return new MosWF_TypedDataContext12(locationReferences).@__Expr170GetTree();
            }
            if ((expressionId == 171)) {
                return new MosWF_TypedDataContext12(locationReferences).@__Expr171GetTree();
            }
            if ((expressionId == 172)) {
                return new MosWF_TypedDataContext12(locationReferences).@__Expr172GetTree();
            }
            if ((expressionId == 173)) {
                return new MosWF_TypedDataContext12_ForReadOnly(locationReferences).@__Expr173GetTree();
            }
            if ((expressionId == 174)) {
                return new MosWF_TypedDataContext12(locationReferences).@__Expr174GetTree();
            }
            if ((expressionId == 175)) {
                return new MosWF_TypedDataContext12(locationReferences).@__Expr175GetTree();
            }
            if ((expressionId == 176)) {
                return new MosWF_TypedDataContext12(locationReferences).@__Expr176GetTree();
            }
            if ((expressionId == 177)) {
                return new MosWF_TypedDataContext12(locationReferences).@__Expr177GetTree();
            }
            if ((expressionId == 178)) {
                return new MosWF_TypedDataContext12_ForReadOnly(locationReferences).@__Expr178GetTree();
            }
            if ((expressionId == 179)) {
                return new MosWF_TypedDataContext12_ForReadOnly(locationReferences).@__Expr179GetTree();
            }
            if ((expressionId == 180)) {
                return new MosWF_TypedDataContext13_ForReadOnly(locationReferences).@__Expr180GetTree();
            }
            if ((expressionId == 181)) {
                return new MosWF_TypedDataContext13(locationReferences).@__Expr181GetTree();
            }
            if ((expressionId == 182)) {
                return new MosWF_TypedDataContext13_ForReadOnly(locationReferences).@__Expr182GetTree();
            }
            if ((expressionId == 183)) {
                return new MosWF_TypedDataContext13(locationReferences).@__Expr183GetTree();
            }
            if ((expressionId == 184)) {
                return new MosWF_TypedDataContext13_ForReadOnly(locationReferences).@__Expr184GetTree();
            }
            if ((expressionId == 185)) {
                return new MosWF_TypedDataContext13(locationReferences).@__Expr185GetTree();
            }
            if ((expressionId == 186)) {
                return new MosWF_TypedDataContext13_ForReadOnly(locationReferences).@__Expr186GetTree();
            }
            if ((expressionId == 187)) {
                return new MosWF_TypedDataContext13(locationReferences).@__Expr187GetTree();
            }
            if ((expressionId == 188)) {
                return new MosWF_TypedDataContext13_ForReadOnly(locationReferences).@__Expr188GetTree();
            }
            if ((expressionId == 189)) {
                return new MosWF_TypedDataContext13(locationReferences).@__Expr189GetTree();
            }
            if ((expressionId == 190)) {
                return new MosWF_TypedDataContext13_ForReadOnly(locationReferences).@__Expr190GetTree();
            }
            if ((expressionId == 191)) {
                return new MosWF_TypedDataContext13(locationReferences).@__Expr191GetTree();
            }
            if ((expressionId == 192)) {
                return new MosWF_TypedDataContext14_ForReadOnly(locationReferences).@__Expr192GetTree();
            }
            if ((expressionId == 193)) {
                return new MosWF_TypedDataContext14_ForReadOnly(locationReferences).@__Expr193GetTree();
            }
            if ((expressionId == 194)) {
                return new MosWF_TypedDataContext14_ForReadOnly(locationReferences).@__Expr194GetTree();
            }
            if ((expressionId == 195)) {
                return new MosWF_TypedDataContext14(locationReferences).@__Expr195GetTree();
            }
            if ((expressionId == 196)) {
                return new MosWF_TypedDataContext14(locationReferences).@__Expr196GetTree();
            }
            if ((expressionId == 197)) {
                return new MosWF_TypedDataContext14(locationReferences).@__Expr197GetTree();
            }
            if ((expressionId == 198)) {
                return new MosWF_TypedDataContext14(locationReferences).@__Expr198GetTree();
            }
            if ((expressionId == 199)) {
                return new MosWF_TypedDataContext14_ForReadOnly(locationReferences).@__Expr199GetTree();
            }
            if ((expressionId == 200)) {
                return new MosWF_TypedDataContext14(locationReferences).@__Expr200GetTree();
            }
            if ((expressionId == 201)) {
                return new MosWF_TypedDataContext14(locationReferences).@__Expr201GetTree();
            }
            if ((expressionId == 202)) {
                return new MosWF_TypedDataContext14(locationReferences).@__Expr202GetTree();
            }
            if ((expressionId == 203)) {
                return new MosWF_TypedDataContext14(locationReferences).@__Expr203GetTree();
            }
            if ((expressionId == 204)) {
                return new MosWF_TypedDataContext14(locationReferences).@__Expr204GetTree();
            }
            if ((expressionId == 205)) {
                return new MosWF_TypedDataContext14(locationReferences).@__Expr205GetTree();
            }
            if ((expressionId == 206)) {
                return new MosWF_TypedDataContext14_ForReadOnly(locationReferences).@__Expr206GetTree();
            }
            if ((expressionId == 207)) {
                return new MosWF_TypedDataContext14(locationReferences).@__Expr207GetTree();
            }
            if ((expressionId == 208)) {
                return new MosWF_TypedDataContext14(locationReferences).@__Expr208GetTree();
            }
            if ((expressionId == 209)) {
                return new MosWF_TypedDataContext14(locationReferences).@__Expr209GetTree();
            }
            if ((expressionId == 210)) {
                return new MosWF_TypedDataContext14(locationReferences).@__Expr210GetTree();
            }
            if ((expressionId == 211)) {
                return new MosWF_TypedDataContext14_ForReadOnly(locationReferences).@__Expr211GetTree();
            }
            if ((expressionId == 212)) {
                return new MosWF_TypedDataContext15(locationReferences).@__Expr212GetTree();
            }
            if ((expressionId == 213)) {
                return new MosWF_TypedDataContext15(locationReferences).@__Expr213GetTree();
            }
            if ((expressionId == 214)) {
                return new MosWF_TypedDataContext15_ForReadOnly(locationReferences).@__Expr214GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class MosWF_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public MosWF_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class MosWF_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public MosWF_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class MosWF_TypedDataContext1 : MosWF_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int nextCount;
            
            protected bool isNeedAction;
            
            protected int curMode;
            
            protected int nextRole;
            
            protected int nextState;
            
            protected int curRole;
            
            protected int nextFunction;
            
            protected int curState;
            
            protected bool isEditMode;
            
            protected int extCount;
            
            public MosWF_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            protected override void GetValueTypeValues() {
                this.nextCount = ((int)(this.GetVariableValue((0 + locationsOffset))));
                this.isNeedAction = ((bool)(this.GetVariableValue((1 + locationsOffset))));
                this.curMode = ((int)(this.GetVariableValue((2 + locationsOffset))));
                this.nextRole = ((int)(this.GetVariableValue((3 + locationsOffset))));
                this.nextState = ((int)(this.GetVariableValue((4 + locationsOffset))));
                this.curRole = ((int)(this.GetVariableValue((5 + locationsOffset))));
                this.nextFunction = ((int)(this.GetVariableValue((6 + locationsOffset))));
                this.curState = ((int)(this.GetVariableValue((7 + locationsOffset))));
                this.isEditMode = ((bool)(this.GetVariableValue((8 + locationsOffset))));
                this.extCount = ((int)(this.GetVariableValue((9 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((0 + locationsOffset), this.nextCount);
                this.SetVariableValue((1 + locationsOffset), this.isNeedAction);
                this.SetVariableValue((2 + locationsOffset), this.curMode);
                this.SetVariableValue((3 + locationsOffset), this.nextRole);
                this.SetVariableValue((4 + locationsOffset), this.nextState);
                this.SetVariableValue((5 + locationsOffset), this.curRole);
                this.SetVariableValue((6 + locationsOffset), this.nextFunction);
                this.SetVariableValue((7 + locationsOffset), this.curState);
                this.SetVariableValue((8 + locationsOffset), this.isEditMode);
                this.SetVariableValue((9 + locationsOffset), this.extCount);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 10))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 10);
                }
                expectedLocationsCount = 10;
                if (((locationReferences[(offset + 0)].Name != "nextCount") 
                            || (locationReferences[(offset + 0)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "isNeedAction") 
                            || (locationReferences[(offset + 1)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "curMode") 
                            || (locationReferences[(offset + 2)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "nextRole") 
                            || (locationReferences[(offset + 3)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "nextState") 
                            || (locationReferences[(offset + 4)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "curRole") 
                            || (locationReferences[(offset + 5)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "nextFunction") 
                            || (locationReferences[(offset + 6)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "curState") 
                            || (locationReferences[(offset + 7)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "isEditMode") 
                            || (locationReferences[(offset + 8)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "extCount") 
                            || (locationReferences[(offset + 9)].Type != typeof(int)))) {
                    return false;
                }
                return MosWF_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class MosWF_TypedDataContext1_ForReadOnly : MosWF_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int nextCount;
            
            protected bool isNeedAction;
            
            protected int curMode;
            
            protected int nextRole;
            
            protected int nextState;
            
            protected int curRole;
            
            protected int nextFunction;
            
            protected int curState;
            
            protected bool isEditMode;
            
            protected int extCount;
            
            public MosWF_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            protected override void GetValueTypeValues() {
                this.nextCount = ((int)(this.GetVariableValue((0 + locationsOffset))));
                this.isNeedAction = ((bool)(this.GetVariableValue((1 + locationsOffset))));
                this.curMode = ((int)(this.GetVariableValue((2 + locationsOffset))));
                this.nextRole = ((int)(this.GetVariableValue((3 + locationsOffset))));
                this.nextState = ((int)(this.GetVariableValue((4 + locationsOffset))));
                this.curRole = ((int)(this.GetVariableValue((5 + locationsOffset))));
                this.nextFunction = ((int)(this.GetVariableValue((6 + locationsOffset))));
                this.curState = ((int)(this.GetVariableValue((7 + locationsOffset))));
                this.isEditMode = ((bool)(this.GetVariableValue((8 + locationsOffset))));
                this.extCount = ((int)(this.GetVariableValue((9 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 10))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 10);
                }
                expectedLocationsCount = 10;
                if (((locationReferences[(offset + 0)].Name != "nextCount") 
                            || (locationReferences[(offset + 0)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "isNeedAction") 
                            || (locationReferences[(offset + 1)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "curMode") 
                            || (locationReferences[(offset + 2)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "nextRole") 
                            || (locationReferences[(offset + 3)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "nextState") 
                            || (locationReferences[(offset + 4)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "curRole") 
                            || (locationReferences[(offset + 5)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "nextFunction") 
                            || (locationReferences[(offset + 6)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "curState") 
                            || (locationReferences[(offset + 7)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "isEditMode") 
                            || (locationReferences[(offset + 8)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "extCount") 
                            || (locationReferences[(offset + 9)].Type != typeof(int)))) {
                    return false;
                }
                return MosWF_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class MosWF_TypedDataContext2 : MosWF_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected bool isNext;
            
            protected bool isEnd;
            
            protected int targetRole;
            
            protected int targetState;
            
            protected int targetFunction;
            
            protected bool targetEditMode;
            
            protected int targetNextRole;
            
            protected bool targetNeedAction;
            
            public MosWF_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            protected override void GetValueTypeValues() {
                this.isNext = ((bool)(this.GetVariableValue((10 + locationsOffset))));
                this.isEnd = ((bool)(this.GetVariableValue((11 + locationsOffset))));
                this.targetRole = ((int)(this.GetVariableValue((12 + locationsOffset))));
                this.targetState = ((int)(this.GetVariableValue((13 + locationsOffset))));
                this.targetFunction = ((int)(this.GetVariableValue((14 + locationsOffset))));
                this.targetEditMode = ((bool)(this.GetVariableValue((15 + locationsOffset))));
                this.targetNextRole = ((int)(this.GetVariableValue((16 + locationsOffset))));
                this.targetNeedAction = ((bool)(this.GetVariableValue((17 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((10 + locationsOffset), this.isNext);
                this.SetVariableValue((11 + locationsOffset), this.isEnd);
                this.SetVariableValue((12 + locationsOffset), this.targetRole);
                this.SetVariableValue((13 + locationsOffset), this.targetState);
                this.SetVariableValue((14 + locationsOffset), this.targetFunction);
                this.SetVariableValue((15 + locationsOffset), this.targetEditMode);
                this.SetVariableValue((16 + locationsOffset), this.targetNextRole);
                this.SetVariableValue((17 + locationsOffset), this.targetNeedAction);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 18))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 18);
                }
                expectedLocationsCount = 18;
                if (((locationReferences[(offset + 10)].Name != "isNext") 
                            || (locationReferences[(offset + 10)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 11)].Name != "isEnd") 
                            || (locationReferences[(offset + 11)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 12)].Name != "targetRole") 
                            || (locationReferences[(offset + 12)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 13)].Name != "targetState") 
                            || (locationReferences[(offset + 13)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 14)].Name != "targetFunction") 
                            || (locationReferences[(offset + 14)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 15)].Name != "targetEditMode") 
                            || (locationReferences[(offset + 15)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 16)].Name != "targetNextRole") 
                            || (locationReferences[(offset + 16)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 17)].Name != "targetNeedAction") 
                            || (locationReferences[(offset + 17)].Type != typeof(bool)))) {
                    return false;
                }
                return MosWF_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class MosWF_TypedDataContext2_ForReadOnly : MosWF_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected bool isNext;
            
            protected bool isEnd;
            
            protected int targetRole;
            
            protected int targetState;
            
            protected int targetFunction;
            
            protected bool targetEditMode;
            
            protected int targetNextRole;
            
            protected bool targetNeedAction;
            
            public MosWF_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            protected override void GetValueTypeValues() {
                this.isNext = ((bool)(this.GetVariableValue((10 + locationsOffset))));
                this.isEnd = ((bool)(this.GetVariableValue((11 + locationsOffset))));
                this.targetRole = ((int)(this.GetVariableValue((12 + locationsOffset))));
                this.targetState = ((int)(this.GetVariableValue((13 + locationsOffset))));
                this.targetFunction = ((int)(this.GetVariableValue((14 + locationsOffset))));
                this.targetEditMode = ((bool)(this.GetVariableValue((15 + locationsOffset))));
                this.targetNextRole = ((int)(this.GetVariableValue((16 + locationsOffset))));
                this.targetNeedAction = ((bool)(this.GetVariableValue((17 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 18))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 18);
                }
                expectedLocationsCount = 18;
                if (((locationReferences[(offset + 10)].Name != "isNext") 
                            || (locationReferences[(offset + 10)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 11)].Name != "isEnd") 
                            || (locationReferences[(offset + 11)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 12)].Name != "targetRole") 
                            || (locationReferences[(offset + 12)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 13)].Name != "targetState") 
                            || (locationReferences[(offset + 13)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 14)].Name != "targetFunction") 
                            || (locationReferences[(offset + 14)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 15)].Name != "targetEditMode") 
                            || (locationReferences[(offset + 15)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 16)].Name != "targetNextRole") 
                            || (locationReferences[(offset + 16)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 17)].Name != "targetNeedAction") 
                            || (locationReferences[(offset + 17)].Type != typeof(bool)))) {
                    return false;
                }
                return MosWF_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class MosWF_TypedDataContext3 : MosWF_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public MosWF_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext3(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr0GetTree() {
                
                #line 2054 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                              targetRole;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr0Get() {
                
                #line 2054 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                              targetRole;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr0Get() {
                this.GetValueTypeValues();
                return this.@__Expr0Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr0Set(int value) {
                
                #line 2054 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                              targetRole = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr0Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr0Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr1GetTree() {
                
                #line 2064 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                              targetNextRole;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr1Get() {
                
                #line 2064 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                              targetNextRole;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr1Set(int value) {
                
                #line 2064 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                              targetNextRole = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr1Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr1Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr2GetTree() {
                
                #line 2074 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                              targetState;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr2Get() {
                
                #line 2074 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                              targetState;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr2Set(int value) {
                
                #line 2074 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                              targetState = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr2Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr2Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 2084 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                              targetFunction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr3Get() {
                
                #line 2084 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                              targetFunction;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr3Set(int value) {
                
                #line 2084 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                              targetFunction = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr3Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr3Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 18))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 18);
                }
                expectedLocationsCount = 18;
                return MosWF_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class MosWF_TypedDataContext3_ForReadOnly : MosWF_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public MosWF_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 18))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 18);
                }
                expectedLocationsCount = 18;
                return MosWF_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class MosWF_TypedDataContext4 : MosWF_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public MosWF_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext4(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 85 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                          targetEditMode;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr6Get() {
                
                #line 85 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                          targetEditMode;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr6Set(bool value) {
                
                #line 85 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                          targetEditMode = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr6Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr6Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 97 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                          targetEditMode;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr7Get() {
                
                #line 97 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                          targetEditMode;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr7Set(bool value) {
                
                #line 97 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                          targetEditMode = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr7Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr7Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 109 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                      isEnd;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr8Get() {
                
                #line 109 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                      isEnd;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr8Set(bool value) {
                
                #line 109 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                      isEnd = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr8Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr8Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr9GetTree() {
                
                #line 119 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                      isNext;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr9Get() {
                
                #line 119 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                      isNext;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr9Set(bool value) {
                
                #line 119 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                      isNext = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr9Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr9Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr10GetTree() {
                
                #line 133 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                      targetEditMode;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr10Get() {
                
                #line 133 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                      targetEditMode;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr10Get() {
                this.GetValueTypeValues();
                return this.@__Expr10Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr10Set(bool value) {
                
                #line 133 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                      targetEditMode = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr10Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr10Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr11GetTree() {
                
                #line 143 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                      isEnd;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr11Get() {
                
                #line 143 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                      isEnd;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr11Get() {
                this.GetValueTypeValues();
                return this.@__Expr11Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr11Set(bool value) {
                
                #line 143 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                      isEnd = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr11Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr11Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr12GetTree() {
                
                #line 153 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                      isNext;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr12Get() {
                
                #line 153 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                      isNext;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr12Get() {
                this.GetValueTypeValues();
                return this.@__Expr12Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr12Set(bool value) {
                
                #line 153 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                      isNext = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr12Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr12Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr14GetTree() {
                
                #line 1998 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                      targetRole;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr14Get() {
                
                #line 1998 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                      targetRole;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr14Get() {
                this.GetValueTypeValues();
                return this.@__Expr14Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr14Set(int value) {
                
                #line 1998 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                      targetRole = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr14Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr14Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr15GetTree() {
                
                #line 2008 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                      targetNextRole;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr15Get() {
                
                #line 2008 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                      targetNextRole;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr15Get() {
                this.GetValueTypeValues();
                return this.@__Expr15Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr15Set(int value) {
                
                #line 2008 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                      targetNextRole = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr15Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr15Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr16GetTree() {
                
                #line 2018 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                      targetState;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr16Get() {
                
                #line 2018 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                      targetState;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr16Get() {
                this.GetValueTypeValues();
                return this.@__Expr16Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr16Set(int value) {
                
                #line 2018 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                      targetState = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr16Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr16Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr17GetTree() {
                
                #line 2028 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                      targetFunction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr17Get() {
                
                #line 2028 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                      targetFunction;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr17Get() {
                this.GetValueTypeValues();
                return this.@__Expr17Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr17Set(int value) {
                
                #line 2028 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                      targetFunction = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr17Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr17Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 18))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 18);
                }
                expectedLocationsCount = 18;
                return MosWF_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class MosWF_TypedDataContext4_ForReadOnly : MosWF_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public MosWF_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 70 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                curState == 1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr4Get() {
                
                #line 70 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                curState == 1;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 78 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                      curRole == targetRole;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr5Get() {
                
                #line 78 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                      curRole == targetRole;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr13GetTree() {
                
                #line 2038 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              isNext;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr13Get() {
                
                #line 2038 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                              isNext;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr13Get() {
                this.GetValueTypeValues();
                return this.@__Expr13Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr18GetTree() {
                
                #line 2043 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              isEnd;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr18Get() {
                
                #line 2043 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                              isEnd;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr18Get() {
                this.GetValueTypeValues();
                return this.@__Expr18Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 18))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 18);
                }
                expectedLocationsCount = 18;
                return MosWF_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class MosWF_TypedDataContext5 : MosWF_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public MosWF_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext5(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr21GetTree() {
                
                #line 187 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                  targetEditMode;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr21Get() {
                
                #line 187 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                  targetEditMode;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr21Get() {
                this.GetValueTypeValues();
                return this.@__Expr21Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr21Set(bool value) {
                
                #line 187 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                  targetEditMode = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr21Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr21Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr22GetTree() {
                
                #line 199 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                  targetEditMode;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr22Get() {
                
                #line 199 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                  targetEditMode;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr22Get() {
                this.GetValueTypeValues();
                return this.@__Expr22Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr22Set(bool value) {
                
                #line 199 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                  targetEditMode = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr22Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr22Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr23GetTree() {
                
                #line 211 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                              isEnd;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr23Get() {
                
                #line 211 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                              isEnd;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr23Get() {
                this.GetValueTypeValues();
                return this.@__Expr23Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr23Set(bool value) {
                
                #line 211 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                              isEnd = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr23Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr23Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr24GetTree() {
                
                #line 221 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                              isNext;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr24Get() {
                
                #line 221 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                              isNext;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr24Get() {
                this.GetValueTypeValues();
                return this.@__Expr24Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr24Set(bool value) {
                
                #line 221 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                              isNext = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr24Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr24Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr25GetTree() {
                
                #line 235 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                              targetEditMode;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr25Get() {
                
                #line 235 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                              targetEditMode;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr25Get() {
                this.GetValueTypeValues();
                return this.@__Expr25Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr25Set(bool value) {
                
                #line 235 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                              targetEditMode = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr25Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr25Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr26GetTree() {
                
                #line 245 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                              isEnd;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr26Get() {
                
                #line 245 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                              isEnd;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr26Get() {
                this.GetValueTypeValues();
                return this.@__Expr26Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr26Set(bool value) {
                
                #line 245 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                              isEnd = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr26Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr26Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr27GetTree() {
                
                #line 255 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                              isNext;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr27Get() {
                
                #line 255 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                              isNext;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr27Get() {
                this.GetValueTypeValues();
                return this.@__Expr27Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr27Set(bool value) {
                
                #line 255 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                              isNext = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr27Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr27Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr30GetTree() {
                
                #line 1849 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                              targetRole;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr30Get() {
                
                #line 1849 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                              targetRole;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr30Get() {
                this.GetValueTypeValues();
                return this.@__Expr30Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr30Set(int value) {
                
                #line 1849 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                              targetRole = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr30Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr30Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr31GetTree() {
                
                #line 1859 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                              targetNextRole;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr31Get() {
                
                #line 1859 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                              targetNextRole;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr31Get() {
                this.GetValueTypeValues();
                return this.@__Expr31Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr31Set(int value) {
                
                #line 1859 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                              targetNextRole = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr31Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr31Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr32GetTree() {
                
                #line 1869 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                              targetState;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr32Get() {
                
                #line 1869 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                              targetState;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr32Get() {
                this.GetValueTypeValues();
                return this.@__Expr32Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr32Set(int value) {
                
                #line 1869 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                              targetState = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr32Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr32Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr33GetTree() {
                
                #line 1879 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                              targetFunction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr33Get() {
                
                #line 1879 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                              targetFunction;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr33Get() {
                this.GetValueTypeValues();
                return this.@__Expr33Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr33Set(int value) {
                
                #line 1879 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                              targetFunction = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr33Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr33Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr35GetTree() {
                
                #line 1898 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                              targetRole;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr35Get() {
                
                #line 1898 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                              targetRole;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr35Get() {
                this.GetValueTypeValues();
                return this.@__Expr35Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr35Set(int value) {
                
                #line 1898 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                              targetRole = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr35Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr35Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr36GetTree() {
                
                #line 1908 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                              targetNextRole;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr36Get() {
                
                #line 1908 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                              targetNextRole;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr36Get() {
                this.GetValueTypeValues();
                return this.@__Expr36Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr36Set(int value) {
                
                #line 1908 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                              targetNextRole = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr36Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr36Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr37GetTree() {
                
                #line 1918 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                              targetState;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr37Get() {
                
                #line 1918 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                              targetState;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr37Get() {
                this.GetValueTypeValues();
                return this.@__Expr37Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr37Set(int value) {
                
                #line 1918 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                              targetState = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr37Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr37Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr38GetTree() {
                
                #line 1928 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                              targetFunction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr38Get() {
                
                #line 1928 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                              targetFunction;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr38Get() {
                this.GetValueTypeValues();
                return this.@__Expr38Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr38Set(int value) {
                
                #line 1928 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                              targetFunction = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr38Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr38Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr40GetTree() {
                
                #line 1947 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                              targetRole;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr40Get() {
                
                #line 1947 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                              targetRole;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr40Get() {
                this.GetValueTypeValues();
                return this.@__Expr40Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr40Set(int value) {
                
                #line 1947 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                              targetRole = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr40Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr40Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr41GetTree() {
                
                #line 1957 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                              targetNextRole;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr41Get() {
                
                #line 1957 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                              targetNextRole;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr41Get() {
                this.GetValueTypeValues();
                return this.@__Expr41Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr41Set(int value) {
                
                #line 1957 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                              targetNextRole = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr41Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr41Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr42GetTree() {
                
                #line 1967 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                              targetState;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr42Get() {
                
                #line 1967 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                              targetState;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr42Get() {
                this.GetValueTypeValues();
                return this.@__Expr42Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr42Set(int value) {
                
                #line 1967 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                              targetState = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr42Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr42Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr43GetTree() {
                
                #line 1977 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                              targetFunction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr43Get() {
                
                #line 1977 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                              targetFunction;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr43Get() {
                this.GetValueTypeValues();
                return this.@__Expr43Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr43Set(int value) {
                
                #line 1977 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                              targetFunction = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr43Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr43Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 18))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 18);
                }
                expectedLocationsCount = 18;
                return MosWF_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class MosWF_TypedDataContext5_ForReadOnly : MosWF_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public MosWF_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr19GetTree() {
                
                #line 172 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                        curState == 2;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr19Get() {
                
                #line 172 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                        curState == 2;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr19Get() {
                this.GetValueTypeValues();
                return this.@__Expr19Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr20GetTree() {
                
                #line 180 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                              curRole == targetRole;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr20Get() {
                
                #line 180 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                              curRole == targetRole;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr20Get() {
                this.GetValueTypeValues();
                return this.@__Expr20Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr28GetTree() {
                
                #line 269 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                      isEnd;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr28Get() {
                
                #line 269 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                      isEnd;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr28Get() {
                this.GetValueTypeValues();
                return this.@__Expr28Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr29GetTree() {
                
                #line 1889 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                      isNext && curMode == 1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr29Get() {
                
                #line 1889 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                      isNext && curMode == 1;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr29Get() {
                this.GetValueTypeValues();
                return this.@__Expr29Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr34GetTree() {
                
                #line 1938 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                      isNext && curMode == 3;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr34Get() {
                
                #line 1938 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                      isNext && curMode == 3;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr34Get() {
                this.GetValueTypeValues();
                return this.@__Expr34Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr39GetTree() {
                
                #line 1987 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                      isNext && curMode == 2;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr39Get() {
                
                #line 1987 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                      isNext && curMode == 2;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr39Get() {
                this.GetValueTypeValues();
                return this.@__Expr39Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 18))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 18);
                }
                expectedLocationsCount = 18;
                return MosWF_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class MosWF_TypedDataContext6 : MosWF_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public MosWF_TypedDataContext6(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext6(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext6(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr47GetTree() {
                
                #line 522 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                        targetEditMode;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr47Get() {
                
                #line 522 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                        targetEditMode;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr47Get() {
                this.GetValueTypeValues();
                return this.@__Expr47Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr47Set(bool value) {
                
                #line 522 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                        targetEditMode = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr47Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr47Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr48GetTree() {
                
                #line 532 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                        targetNeedAction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr48Get() {
                
                #line 532 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                        targetNeedAction;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr48Get() {
                this.GetValueTypeValues();
                return this.@__Expr48Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr48Set(bool value) {
                
                #line 532 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                        targetNeedAction = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr48Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr48Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr49GetTree() {
                
                #line 545 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                      targetEditMode;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr49Get() {
                
                #line 545 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                      targetEditMode;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr49Get() {
                this.GetValueTypeValues();
                return this.@__Expr49Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr49Set(bool value) {
                
                #line 545 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                      targetEditMode = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr49Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr49Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr50GetTree() {
                
                #line 559 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                  targetEditMode;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr50Get() {
                
                #line 559 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                  targetEditMode;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr50Get() {
                this.GetValueTypeValues();
                return this.@__Expr50Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr50Set(bool value) {
                
                #line 559 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                  targetEditMode = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr50Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr50Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr51GetTree() {
                
                #line 571 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                              isEnd;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr51Get() {
                
                #line 571 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                              isEnd;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr51Get() {
                this.GetValueTypeValues();
                return this.@__Expr51Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr51Set(bool value) {
                
                #line 571 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                              isEnd = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr51Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr51Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr52GetTree() {
                
                #line 581 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                              isNext;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr52Get() {
                
                #line 581 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                              isNext;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr52Get() {
                this.GetValueTypeValues();
                return this.@__Expr52Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr52Set(bool value) {
                
                #line 581 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                              isNext = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr52Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr52Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr53GetTree() {
                
                #line 595 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                              targetEditMode;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr53Get() {
                
                #line 595 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                              targetEditMode;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr53Get() {
                this.GetValueTypeValues();
                return this.@__Expr53Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr53Set(bool value) {
                
                #line 595 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                              targetEditMode = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr53Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr53Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr54GetTree() {
                
                #line 605 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                              isEnd;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr54Get() {
                
                #line 605 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                              isEnd;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr54Get() {
                this.GetValueTypeValues();
                return this.@__Expr54Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr54Set(bool value) {
                
                #line 605 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                              isEnd = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr54Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr54Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr55GetTree() {
                
                #line 615 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                              isNext;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr55Get() {
                
                #line 615 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                              isNext;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr55Get() {
                this.GetValueTypeValues();
                return this.@__Expr55Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr55Set(bool value) {
                
                #line 615 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                              isNext = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr55Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr55Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr58GetTree() {
                
                #line 1698 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                              targetRole;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr58Get() {
                
                #line 1698 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                              targetRole;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr58Get() {
                this.GetValueTypeValues();
                return this.@__Expr58Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr58Set(int value) {
                
                #line 1698 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                              targetRole = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr58Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr58Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr59GetTree() {
                
                #line 1708 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                              targetNextRole;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr59Get() {
                
                #line 1708 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                              targetNextRole;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr59Get() {
                this.GetValueTypeValues();
                return this.@__Expr59Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr59Set(int value) {
                
                #line 1708 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                              targetNextRole = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr59Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr59Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr60GetTree() {
                
                #line 1718 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                              targetState;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr60Get() {
                
                #line 1718 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                              targetState;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr60Get() {
                this.GetValueTypeValues();
                return this.@__Expr60Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr60Set(int value) {
                
                #line 1718 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                              targetState = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr60Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr60Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr61GetTree() {
                
                #line 1728 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                              targetFunction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr61Get() {
                
                #line 1728 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                              targetFunction;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr61Get() {
                this.GetValueTypeValues();
                return this.@__Expr61Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr61Set(int value) {
                
                #line 1728 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                              targetFunction = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr61Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr61Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 18))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 18);
                }
                expectedLocationsCount = 18;
                return MosWF_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class MosWF_TypedDataContext6_ForReadOnly : MosWF_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public MosWF_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr44GetTree() {
                
                #line 499 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                        curState == 6;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr44Get() {
                
                #line 499 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                        curState == 6;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr44Get() {
                this.GetValueTypeValues();
                return this.@__Expr44Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr45GetTree() {
                
                #line 507 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                              curRole == targetRole;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr45Get() {
                
                #line 507 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                              curRole == targetRole;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr45Get() {
                this.GetValueTypeValues();
                return this.@__Expr45Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr46GetTree() {
                
                #line 514 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                  curMode == 2;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr46Get() {
                
                #line 514 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                  curMode == 2;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr46Get() {
                this.GetValueTypeValues();
                return this.@__Expr46Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr56GetTree() {
                
                #line 629 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                      isEnd;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr56Get() {
                
                #line 629 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                      isEnd;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr56Get() {
                this.GetValueTypeValues();
                return this.@__Expr56Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr57GetTree() {
                
                #line 1738 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                      isNext && (curMode == 1 || curMode == 2);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr57Get() {
                
                #line 1738 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                      isNext && (curMode == 1 || curMode == 2);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr57Get() {
                this.GetValueTypeValues();
                return this.@__Expr57Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 18))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 18);
                }
                expectedLocationsCount = 18;
                return MosWF_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class MosWF_TypedDataContext7 : MosWF_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public MosWF_TypedDataContext7(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext7(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext7(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr65GetTree() {
                
                #line 382 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                targetEditMode;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr65Get() {
                
                #line 382 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                targetEditMode;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr65Get() {
                this.GetValueTypeValues();
                return this.@__Expr65Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr65Set(bool value) {
                
                #line 382 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                targetEditMode = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr65Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr65Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr66GetTree() {
                
                #line 392 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                targetNeedAction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr66Get() {
                
                #line 392 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                targetNeedAction;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr66Get() {
                this.GetValueTypeValues();
                return this.@__Expr66Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr66Set(bool value) {
                
                #line 392 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                targetNeedAction = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr66Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr66Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr67GetTree() {
                
                #line 405 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                              targetEditMode;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr67Get() {
                
                #line 405 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                              targetEditMode;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr67Get() {
                this.GetValueTypeValues();
                return this.@__Expr67Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr67Set(bool value) {
                
                #line 405 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                              targetEditMode = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr67Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr67Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr68GetTree() {
                
                #line 419 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                          targetEditMode;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr68Get() {
                
                #line 419 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                          targetEditMode;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr68Get() {
                this.GetValueTypeValues();
                return this.@__Expr68Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr68Set(bool value) {
                
                #line 419 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                          targetEditMode = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr68Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr68Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr69GetTree() {
                
                #line 431 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                      isEnd;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr69Get() {
                
                #line 431 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                      isEnd;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr69Get() {
                this.GetValueTypeValues();
                return this.@__Expr69Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr69Set(bool value) {
                
                #line 431 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                      isEnd = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr69Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr69Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr70GetTree() {
                
                #line 441 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                      isNext;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr70Get() {
                
                #line 441 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                      isNext;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr70Get() {
                this.GetValueTypeValues();
                return this.@__Expr70Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr70Set(bool value) {
                
                #line 441 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                      isNext = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr70Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr70Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr71GetTree() {
                
                #line 455 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                      targetEditMode;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr71Get() {
                
                #line 455 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                      targetEditMode;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr71Get() {
                this.GetValueTypeValues();
                return this.@__Expr71Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr71Set(bool value) {
                
                #line 455 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                      targetEditMode = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr71Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr71Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr72GetTree() {
                
                #line 465 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                      isEnd;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr72Get() {
                
                #line 465 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                      isEnd;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr72Get() {
                this.GetValueTypeValues();
                return this.@__Expr72Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr72Set(bool value) {
                
                #line 465 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                      isEnd = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr72Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr72Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr73GetTree() {
                
                #line 475 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                      isNext;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr73Get() {
                
                #line 475 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                      isNext;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr73Get() {
                this.GetValueTypeValues();
                return this.@__Expr73Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr73Set(bool value) {
                
                #line 475 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                      isNext = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr73Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr73Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr76GetTree() {
                
                #line 1749 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                      targetRole;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr76Get() {
                
                #line 1749 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                      targetRole;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr76Get() {
                this.GetValueTypeValues();
                return this.@__Expr76Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr76Set(int value) {
                
                #line 1749 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                      targetRole = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr76Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr76Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr77GetTree() {
                
                #line 1759 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                      targetNextRole;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr77Get() {
                
                #line 1759 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                      targetNextRole;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr77Get() {
                this.GetValueTypeValues();
                return this.@__Expr77Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr77Set(int value) {
                
                #line 1759 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                      targetNextRole = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr77Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr77Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr78GetTree() {
                
                #line 1769 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                      targetState;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr78Get() {
                
                #line 1769 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                      targetState;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr78Get() {
                this.GetValueTypeValues();
                return this.@__Expr78Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr78Set(int value) {
                
                #line 1769 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                      targetState = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr78Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr78Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr79GetTree() {
                
                #line 1779 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                      targetFunction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr79Get() {
                
                #line 1779 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                      targetFunction;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr79Get() {
                this.GetValueTypeValues();
                return this.@__Expr79Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr79Set(int value) {
                
                #line 1779 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                      targetFunction = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr79Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr79Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr81GetTree() {
                
                #line 1798 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                      targetRole;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr81Get() {
                
                #line 1798 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                      targetRole;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr81Get() {
                this.GetValueTypeValues();
                return this.@__Expr81Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr81Set(int value) {
                
                #line 1798 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                      targetRole = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr81Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr81Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr82GetTree() {
                
                #line 1808 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                      targetNextRole;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr82Get() {
                
                #line 1808 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                      targetNextRole;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr82Get() {
                this.GetValueTypeValues();
                return this.@__Expr82Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr82Set(int value) {
                
                #line 1808 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                      targetNextRole = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr82Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr82Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr83GetTree() {
                
                #line 1818 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                      targetState;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr83Get() {
                
                #line 1818 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                      targetState;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr83Get() {
                this.GetValueTypeValues();
                return this.@__Expr83Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr83Set(int value) {
                
                #line 1818 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                      targetState = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr83Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr83Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr84GetTree() {
                
                #line 1828 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                      targetFunction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr84Get() {
                
                #line 1828 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                      targetFunction;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr84Get() {
                this.GetValueTypeValues();
                return this.@__Expr84Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr84Set(int value) {
                
                #line 1828 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                      targetFunction = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr84Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr84Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 18))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 18);
                }
                expectedLocationsCount = 18;
                return MosWF_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class MosWF_TypedDataContext7_ForReadOnly : MosWF_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public MosWF_TypedDataContext7_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext7_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext7_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr62GetTree() {
                
                #line 359 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                curState == 3;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr62Get() {
                
                #line 359 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                curState == 3;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr62Get() {
                this.GetValueTypeValues();
                return this.@__Expr62Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr63GetTree() {
                
                #line 367 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                      curRole == targetRole;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr63Get() {
                
                #line 367 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                      curRole == targetRole;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr63Get() {
                this.GetValueTypeValues();
                return this.@__Expr63Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr64GetTree() {
                
                #line 374 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                          curMode == 1 || curMode == 2;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr64Get() {
                
                #line 374 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                          curMode == 1 || curMode == 2;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr64Get() {
                this.GetValueTypeValues();
                return this.@__Expr64Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr74GetTree() {
                
                #line 489 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                              isEnd;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr74Get() {
                
                #line 489 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                              isEnd;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr74Get() {
                this.GetValueTypeValues();
                return this.@__Expr74Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr75GetTree() {
                
                #line 1789 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                              isNext && curMode == 1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr75Get() {
                
                #line 1789 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                              isNext && curMode == 1;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr75Get() {
                this.GetValueTypeValues();
                return this.@__Expr75Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr80GetTree() {
                
                #line 1838 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                              isNext && curMode == 2;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr80Get() {
                
                #line 1838 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                              isNext && curMode == 2;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr80Get() {
                this.GetValueTypeValues();
                return this.@__Expr80Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 18))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 18);
                }
                expectedLocationsCount = 18;
                return MosWF_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class MosWF_TypedDataContext8 : MosWF_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public MosWF_TypedDataContext8(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext8(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext8(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr88GetTree() {
                
                #line 797 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                                        targetEditMode;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr88Get() {
                
                #line 797 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                                        targetEditMode;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr88Get() {
                this.GetValueTypeValues();
                return this.@__Expr88Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr88Set(bool value) {
                
                #line 797 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                                        targetEditMode = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr88Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr88Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr89GetTree() {
                
                #line 807 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                                        targetNeedAction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr89Get() {
                
                #line 807 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                                        targetNeedAction;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr89Get() {
                this.GetValueTypeValues();
                return this.@__Expr89Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr89Set(bool value) {
                
                #line 807 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                                        targetNeedAction = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr89Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr89Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr90GetTree() {
                
                #line 820 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                                      targetEditMode;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr90Get() {
                
                #line 820 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                                      targetEditMode;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr90Get() {
                this.GetValueTypeValues();
                return this.@__Expr90Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr90Set(bool value) {
                
                #line 820 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                                      targetEditMode = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr90Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr90Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr91GetTree() {
                
                #line 834 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                                  targetEditMode;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr91Get() {
                
                #line 834 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                                  targetEditMode;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr91Get() {
                this.GetValueTypeValues();
                return this.@__Expr91Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr91Set(bool value) {
                
                #line 834 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                                  targetEditMode = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr91Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr91Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr92GetTree() {
                
                #line 846 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                              isEnd;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr92Get() {
                
                #line 846 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                              isEnd;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr92Get() {
                this.GetValueTypeValues();
                return this.@__Expr92Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr92Set(bool value) {
                
                #line 846 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                              isEnd = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr92Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr92Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr93GetTree() {
                
                #line 856 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                              isNext;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr93Get() {
                
                #line 856 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                              isNext;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr93Get() {
                this.GetValueTypeValues();
                return this.@__Expr93Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr93Set(bool value) {
                
                #line 856 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                              isNext = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr93Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr93Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr94GetTree() {
                
                #line 870 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                              targetEditMode;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr94Get() {
                
                #line 870 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                              targetEditMode;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr94Get() {
                this.GetValueTypeValues();
                return this.@__Expr94Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr94Set(bool value) {
                
                #line 870 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                              targetEditMode = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr94Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr94Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr95GetTree() {
                
                #line 880 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                              isEnd;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr95Get() {
                
                #line 880 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                              isEnd;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr95Get() {
                this.GetValueTypeValues();
                return this.@__Expr95Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr95Set(bool value) {
                
                #line 880 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                              isEnd = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr95Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr95Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr96GetTree() {
                
                #line 890 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                              isNext;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr96Get() {
                
                #line 890 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                              isNext;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr96Get() {
                this.GetValueTypeValues();
                return this.@__Expr96Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr96Set(bool value) {
                
                #line 890 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                              isNext = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr96Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr96Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr98GetTree() {
                
                #line 1066 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                              targetRole;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr98Get() {
                
                #line 1066 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                              targetRole;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr98Get() {
                this.GetValueTypeValues();
                return this.@__Expr98Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr98Set(int value) {
                
                #line 1066 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                              targetRole = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr98Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr98Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr99GetTree() {
                
                #line 1076 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                              targetNextRole;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr99Get() {
                
                #line 1076 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                              targetNextRole;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr99Get() {
                this.GetValueTypeValues();
                return this.@__Expr99Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr99Set(int value) {
                
                #line 1076 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                              targetNextRole = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr99Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr99Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr100GetTree() {
                
                #line 1086 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                              targetState;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr100Get() {
                
                #line 1086 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                              targetState;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr100Get() {
                this.GetValueTypeValues();
                return this.@__Expr100Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr100Set(int value) {
                
                #line 1086 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                              targetState = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr100Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr100Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr101GetTree() {
                
                #line 1096 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                              targetFunction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr101Get() {
                
                #line 1096 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                              targetFunction;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr101Get() {
                this.GetValueTypeValues();
                return this.@__Expr101Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr101Set(int value) {
                
                #line 1096 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                              targetFunction = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr101Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr101Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr103GetTree() {
                
                #line 1476 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                              targetRole;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr103Get() {
                
                #line 1476 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                              targetRole;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr103Get() {
                this.GetValueTypeValues();
                return this.@__Expr103Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr103Set(int value) {
                
                #line 1476 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                              targetRole = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr103Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr103Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr104GetTree() {
                
                #line 1486 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                              targetNextRole;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr104Get() {
                
                #line 1486 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                              targetNextRole;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr104Get() {
                this.GetValueTypeValues();
                return this.@__Expr104Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr104Set(int value) {
                
                #line 1486 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                              targetNextRole = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr104Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr104Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr105GetTree() {
                
                #line 1496 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                              targetState;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr105Get() {
                
                #line 1496 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                              targetState;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr105Get() {
                this.GetValueTypeValues();
                return this.@__Expr105Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr105Set(int value) {
                
                #line 1496 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                              targetState = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr105Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr105Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr106GetTree() {
                
                #line 1506 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                              targetFunction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr106Get() {
                
                #line 1506 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                              targetFunction;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr106Get() {
                this.GetValueTypeValues();
                return this.@__Expr106Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr106Set(int value) {
                
                #line 1506 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                              targetFunction = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr106Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr106Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 18))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 18);
                }
                expectedLocationsCount = 18;
                return MosWF_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class MosWF_TypedDataContext8_ForReadOnly : MosWF_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public MosWF_TypedDataContext8_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext8_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext8_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr85GetTree() {
                
                #line 774 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                        curState == 5;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr85Get() {
                
                #line 774 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                        curState == 5;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr85Get() {
                this.GetValueTypeValues();
                return this.@__Expr85Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr86GetTree() {
                
                #line 782 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                              curRole == targetRole;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr86Get() {
                
                #line 782 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                              curRole == targetRole;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr86Get() {
                this.GetValueTypeValues();
                return this.@__Expr86Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr87GetTree() {
                
                #line 789 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                                  curMode == 1 || curMode == 2;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr87Get() {
                
                #line 789 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                                  curMode == 1 || curMode == 2;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr87Get() {
                this.GetValueTypeValues();
                return this.@__Expr87Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr97GetTree() {
                
                #line 1106 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                      isNext && curMode == 3;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr97Get() {
                
                #line 1106 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                      isNext && curMode == 3;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr97Get() {
                this.GetValueTypeValues();
                return this.@__Expr97Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr102GetTree() {
                
                #line 1516 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                      isNext && curMode == 2 && extCount < 2;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr102Get() {
                
                #line 1516 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                      isNext && curMode == 2 && extCount < 2;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr102Get() {
                this.GetValueTypeValues();
                return this.@__Expr102Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr107GetTree() {
                
                #line 1521 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                      isEnd;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr107Get() {
                
                #line 1521 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                      isEnd;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr107Get() {
                this.GetValueTypeValues();
                return this.@__Expr107Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 18))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 18);
                }
                expectedLocationsCount = 18;
                return MosWF_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class MosWF_TypedDataContext9 : MosWF_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public MosWF_TypedDataContext9(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext9(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext9(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr111GetTree() {
                
                #line 662 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                                targetEditMode;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr111Get() {
                
                #line 662 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                                targetEditMode;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr111Get() {
                this.GetValueTypeValues();
                return this.@__Expr111Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr111Set(bool value) {
                
                #line 662 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                                targetEditMode = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr111Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr111Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr112GetTree() {
                
                #line 672 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                                targetNeedAction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr112Get() {
                
                #line 672 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                                targetNeedAction;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr112Get() {
                this.GetValueTypeValues();
                return this.@__Expr112Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr112Set(bool value) {
                
                #line 672 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                                targetNeedAction = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr112Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr112Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr113GetTree() {
                
                #line 685 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                              targetEditMode;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr113Get() {
                
                #line 685 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                              targetEditMode;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr113Get() {
                this.GetValueTypeValues();
                return this.@__Expr113Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr113Set(bool value) {
                
                #line 685 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                              targetEditMode = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr113Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr113Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr114GetTree() {
                
                #line 699 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                          targetEditMode;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr114Get() {
                
                #line 699 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                          targetEditMode;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr114Get() {
                this.GetValueTypeValues();
                return this.@__Expr114Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr114Set(bool value) {
                
                #line 699 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                          targetEditMode = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr114Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr114Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr115GetTree() {
                
                #line 711 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                      isEnd;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr115Get() {
                
                #line 711 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                      isEnd;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr115Get() {
                this.GetValueTypeValues();
                return this.@__Expr115Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr115Set(bool value) {
                
                #line 711 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                      isEnd = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr115Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr115Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr116GetTree() {
                
                #line 721 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                      isNext;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr116Get() {
                
                #line 721 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                      isNext;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr116Get() {
                this.GetValueTypeValues();
                return this.@__Expr116Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr116Set(bool value) {
                
                #line 721 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                      isNext = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr116Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr116Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr117GetTree() {
                
                #line 735 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                      targetEditMode;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr117Get() {
                
                #line 735 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                      targetEditMode;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr117Get() {
                this.GetValueTypeValues();
                return this.@__Expr117Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr117Set(bool value) {
                
                #line 735 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                      targetEditMode = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr117Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr117Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr118GetTree() {
                
                #line 745 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                      isEnd;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr118Get() {
                
                #line 745 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                      isEnd;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr118Get() {
                this.GetValueTypeValues();
                return this.@__Expr118Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr118Set(bool value) {
                
                #line 745 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                      isEnd = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr118Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr118Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr119GetTree() {
                
                #line 755 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                      isNext;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr119Get() {
                
                #line 755 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                      isNext;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr119Get() {
                this.GetValueTypeValues();
                return this.@__Expr119Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr119Set(bool value) {
                
                #line 755 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                      isNext = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr119Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr119Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr121GetTree() {
                
                #line 1532 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                      targetFunction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr121Get() {
                
                #line 1532 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                      targetFunction;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr121Get() {
                this.GetValueTypeValues();
                return this.@__Expr121Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr121Set(int value) {
                
                #line 1532 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                      targetFunction = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr121Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr121Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr124GetTree() {
                
                #line 1556 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                      targetRole;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr124Get() {
                
                #line 1556 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                      targetRole;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr124Get() {
                this.GetValueTypeValues();
                return this.@__Expr124Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr124Set(int value) {
                
                #line 1556 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                      targetRole = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr124Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr124Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr125GetTree() {
                
                #line 1566 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                      targetNextRole;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr125Get() {
                
                #line 1566 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                      targetNextRole;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr125Get() {
                this.GetValueTypeValues();
                return this.@__Expr125Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr125Set(int value) {
                
                #line 1566 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                      targetNextRole = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr125Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr125Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr126GetTree() {
                
                #line 1576 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                      targetState;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr126Get() {
                
                #line 1576 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                      targetState;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr126Get() {
                this.GetValueTypeValues();
                return this.@__Expr126Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr126Set(int value) {
                
                #line 1576 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                      targetState = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr126Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr126Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr127GetTree() {
                
                #line 1586 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                      targetFunction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr127Get() {
                
                #line 1586 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                      targetFunction;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr127Get() {
                this.GetValueTypeValues();
                return this.@__Expr127Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr127Set(int value) {
                
                #line 1586 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                      targetFunction = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr127Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr127Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr130GetTree() {
                
                #line 1612 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                          targetFunction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr130Get() {
                
                #line 1612 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                          targetFunction;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr130Get() {
                this.GetValueTypeValues();
                return this.@__Expr130Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr130Set(int value) {
                
                #line 1612 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                          targetFunction = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr130Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr130Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr131GetTree() {
                
                #line 1626 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                          targetRole;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr131Get() {
                
                #line 1626 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                          targetRole;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr131Get() {
                this.GetValueTypeValues();
                return this.@__Expr131Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr131Set(int value) {
                
                #line 1626 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                          targetRole = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr131Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr131Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr132GetTree() {
                
                #line 1636 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                          targetNextRole;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr132Get() {
                
                #line 1636 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                          targetNextRole;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr132Get() {
                this.GetValueTypeValues();
                return this.@__Expr132Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr132Set(int value) {
                
                #line 1636 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                          targetNextRole = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr132Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr132Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr133GetTree() {
                
                #line 1646 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                          targetState;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr133Get() {
                
                #line 1646 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                          targetState;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr133Get() {
                this.GetValueTypeValues();
                return this.@__Expr133Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr133Set(int value) {
                
                #line 1646 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                          targetState = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr133Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr133Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr134GetTree() {
                
                #line 1656 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                          targetFunction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr134Get() {
                
                #line 1656 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                          targetFunction;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr134Get() {
                this.GetValueTypeValues();
                return this.@__Expr134Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr134Set(int value) {
                
                #line 1656 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                          targetFunction = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr134Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr134Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr136GetTree() {
                
                #line 1677 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                      targetFunction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr136Get() {
                
                #line 1677 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                      targetFunction;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr136Get() {
                this.GetValueTypeValues();
                return this.@__Expr136Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr136Set(int value) {
                
                #line 1677 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                      targetFunction = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr136Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr136Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 18))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 18);
                }
                expectedLocationsCount = 18;
                return MosWF_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class MosWF_TypedDataContext9_ForReadOnly : MosWF_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public MosWF_TypedDataContext9_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext9_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext9_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr108GetTree() {
                
                #line 639 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                curState == 4;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr108Get() {
                
                #line 639 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                curState == 4;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr108Get() {
                this.GetValueTypeValues();
                return this.@__Expr108Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr109GetTree() {
                
                #line 647 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                      curRole == targetRole;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr109Get() {
                
                #line 647 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                      curRole == targetRole;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr109Get() {
                this.GetValueTypeValues();
                return this.@__Expr109Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr110GetTree() {
                
                #line 654 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                          curMode == 1 || curMode == 2;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr110Get() {
                
                #line 654 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                          curMode == 1 || curMode == 2;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr110Get() {
                this.GetValueTypeValues();
                return this.@__Expr110Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr120GetTree() {
                
                #line 1542 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                              isNext && curMode == 1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr120Get() {
                
                #line 1542 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                              isNext && curMode == 1;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr120Get() {
                this.GetValueTypeValues();
                return this.@__Expr120Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr122GetTree() {
                
                #line 1547 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                              isEnd;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr122Get() {
                
                #line 1547 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                              isEnd;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr122Get() {
                this.GetValueTypeValues();
                return this.@__Expr122Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr123GetTree() {
                
                #line 1596 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                              isNext && curMode == 3;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr123Get() {
                
                #line 1596 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                              isNext && curMode == 3;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr123Get() {
                this.GetValueTypeValues();
                return this.@__Expr123Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr128GetTree() {
                
                #line 1668 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                              isNext && curMode == 2;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr128Get() {
                
                #line 1668 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                              isNext && curMode == 2;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr128Get() {
                this.GetValueTypeValues();
                return this.@__Expr128Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr129GetTree() {
                
                #line 1604 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                    extCount < 2;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr129Get() {
                
                #line 1604 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                    extCount < 2;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr129Get() {
                this.GetValueTypeValues();
                return this.@__Expr129Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr135GetTree() {
                
                #line 1687 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                              isNext && curMode == 3;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr135Get() {
                
                #line 1687 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                              isNext && curMode == 3;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr135Get() {
                this.GetValueTypeValues();
                return this.@__Expr135Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 18))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 18);
                }
                expectedLocationsCount = 18;
                return MosWF_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class MosWF_TypedDataContext10 : MosWF_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public MosWF_TypedDataContext10(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext10(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext10(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr139GetTree() {
                
                #line 1278 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                                                  targetEditMode;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr139Get() {
                
                #line 1278 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                                                  targetEditMode;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr139Get() {
                this.GetValueTypeValues();
                return this.@__Expr139Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr139Set(bool value) {
                
                #line 1278 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                                                  targetEditMode = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr139Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr139Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr140GetTree() {
                
                #line 1290 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                                                  targetEditMode;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr140Get() {
                
                #line 1290 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                                                  targetEditMode;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr140Get() {
                this.GetValueTypeValues();
                return this.@__Expr140Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr140Set(bool value) {
                
                #line 1290 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                                                  targetEditMode = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr140Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr140Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr141GetTree() {
                
                #line 1302 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                                              isEnd;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr141Get() {
                
                #line 1302 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                                              isEnd;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr141Get() {
                this.GetValueTypeValues();
                return this.@__Expr141Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr141Set(bool value) {
                
                #line 1302 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                                              isEnd = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr141Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr141Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr142GetTree() {
                
                #line 1312 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                                              isNext;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr142Get() {
                
                #line 1312 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                                              isNext;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr142Get() {
                this.GetValueTypeValues();
                return this.@__Expr142Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr142Set(bool value) {
                
                #line 1312 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                                              isNext = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr142Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr142Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr143GetTree() {
                
                #line 1326 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                                              targetEditMode;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr143Get() {
                
                #line 1326 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                                              targetEditMode;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr143Get() {
                this.GetValueTypeValues();
                return this.@__Expr143Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr143Set(bool value) {
                
                #line 1326 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                                              targetEditMode = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr143Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr143Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr144GetTree() {
                
                #line 1336 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                                              isEnd;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr144Get() {
                
                #line 1336 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                                              isEnd;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr144Get() {
                this.GetValueTypeValues();
                return this.@__Expr144Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr144Set(bool value) {
                
                #line 1336 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                                              isEnd = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr144Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr144Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr145GetTree() {
                
                #line 1346 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                                              isNext;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr145Get() {
                
                #line 1346 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                                              isNext;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr145Get() {
                this.GetValueTypeValues();
                return this.@__Expr145Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr145Set(bool value) {
                
                #line 1346 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                                              isNext = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr145Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr145Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr147GetTree() {
                
                #line 1364 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                                              targetRole;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr147Get() {
                
                #line 1364 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                                              targetRole;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr147Get() {
                this.GetValueTypeValues();
                return this.@__Expr147Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr147Set(int value) {
                
                #line 1364 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                                              targetRole = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr147Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr147Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr148GetTree() {
                
                #line 1374 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                                              targetNextRole;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr148Get() {
                
                #line 1374 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                                              targetNextRole;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr148Get() {
                this.GetValueTypeValues();
                return this.@__Expr148Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr148Set(int value) {
                
                #line 1374 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                                              targetNextRole = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr148Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr148Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr149GetTree() {
                
                #line 1384 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                                              targetState;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr149Get() {
                
                #line 1384 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                                              targetState;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr149Get() {
                this.GetValueTypeValues();
                return this.@__Expr149Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr149Set(int value) {
                
                #line 1384 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                                              targetState = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr149Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr149Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr150GetTree() {
                
                #line 1394 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                                              targetFunction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr150Get() {
                
                #line 1394 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                                              targetFunction;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr150Get() {
                this.GetValueTypeValues();
                return this.@__Expr150Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr150Set(int value) {
                
                #line 1394 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                                              targetFunction = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr150Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr150Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 18))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 18);
                }
                expectedLocationsCount = 18;
                return MosWF_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class MosWF_TypedDataContext10_ForReadOnly : MosWF_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public MosWF_TypedDataContext10_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext10_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext10_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr137GetTree() {
                
                #line 1263 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                                        curState == 7;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr137Get() {
                
                #line 1263 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                                        curState == 7;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr137Get() {
                this.GetValueTypeValues();
                return this.@__Expr137Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr138GetTree() {
                
                #line 1271 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                                              curRole == targetRole;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr138Get() {
                
                #line 1271 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                                              curRole == targetRole;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr138Get() {
                this.GetValueTypeValues();
                return this.@__Expr138Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr146GetTree() {
                
                #line 1404 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                                      isNext && curMode == 2;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr146Get() {
                
                #line 1404 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                                      isNext && curMode == 2;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr146Get() {
                this.GetValueTypeValues();
                return this.@__Expr146Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr151GetTree() {
                
                #line 1409 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                                      isEnd;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr151Get() {
                
                #line 1409 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                                      isEnd;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr151Get() {
                this.GetValueTypeValues();
                return this.@__Expr151Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 18))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 18);
                }
                expectedLocationsCount = 18;
                return MosWF_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class MosWF_TypedDataContext11 : MosWF_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public MosWF_TypedDataContext11(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext11(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext11(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr154GetTree() {
                
                #line 924 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                                          targetEditMode;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr154Get() {
                
                #line 924 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                                          targetEditMode;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr154Get() {
                this.GetValueTypeValues();
                return this.@__Expr154Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr154Set(bool value) {
                
                #line 924 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                                          targetEditMode = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr154Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr154Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr155GetTree() {
                
                #line 936 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                                          targetEditMode;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr155Get() {
                
                #line 936 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                                          targetEditMode;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr155Get() {
                this.GetValueTypeValues();
                return this.@__Expr155Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr155Set(bool value) {
                
                #line 936 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                                          targetEditMode = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr155Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr155Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr156GetTree() {
                
                #line 948 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                                      isEnd;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr156Get() {
                
                #line 948 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                                      isEnd;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr156Get() {
                this.GetValueTypeValues();
                return this.@__Expr156Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr156Set(bool value) {
                
                #line 948 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                                      isEnd = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr156Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr156Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr157GetTree() {
                
                #line 958 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                                      isNext;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr157Get() {
                
                #line 958 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                                      isNext;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr157Get() {
                this.GetValueTypeValues();
                return this.@__Expr157Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr157Set(bool value) {
                
                #line 958 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                                      isNext = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr157Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr157Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr158GetTree() {
                
                #line 972 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                                      targetEditMode;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr158Get() {
                
                #line 972 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                                      targetEditMode;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr158Get() {
                this.GetValueTypeValues();
                return this.@__Expr158Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr158Set(bool value) {
                
                #line 972 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                                      targetEditMode = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr158Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr158Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr159GetTree() {
                
                #line 982 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                                      isEnd;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr159Get() {
                
                #line 982 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                                      isEnd;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr159Get() {
                this.GetValueTypeValues();
                return this.@__Expr159Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr159Set(bool value) {
                
                #line 982 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                                      isEnd = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr159Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr159Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr160GetTree() {
                
                #line 992 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                                      isNext;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr160Get() {
                
                #line 992 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                                      isNext;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr160Get() {
                this.GetValueTypeValues();
                return this.@__Expr160Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr160Set(bool value) {
                
                #line 992 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                                      isNext = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr160Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr160Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr162GetTree() {
                
                #line 1010 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                                      targetRole;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr162Get() {
                
                #line 1010 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                                      targetRole;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr162Get() {
                this.GetValueTypeValues();
                return this.@__Expr162Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr162Set(int value) {
                
                #line 1010 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                                      targetRole = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr162Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr162Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr163GetTree() {
                
                #line 1020 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                                      targetNextRole;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr163Get() {
                
                #line 1020 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                                      targetNextRole;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr163Get() {
                this.GetValueTypeValues();
                return this.@__Expr163Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr163Set(int value) {
                
                #line 1020 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                                      targetNextRole = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr163Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr163Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr164GetTree() {
                
                #line 1030 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                                      targetState;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr164Get() {
                
                #line 1030 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                                      targetState;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr164Get() {
                this.GetValueTypeValues();
                return this.@__Expr164Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr164Set(int value) {
                
                #line 1030 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                                      targetState = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr164Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr164Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr165GetTree() {
                
                #line 1040 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                                      targetFunction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr165Get() {
                
                #line 1040 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                                      targetFunction;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr165Get() {
                this.GetValueTypeValues();
                return this.@__Expr165Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr165Set(int value) {
                
                #line 1040 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                                      targetFunction = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr165Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr165Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 18))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 18);
                }
                expectedLocationsCount = 18;
                return MosWF_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class MosWF_TypedDataContext11_ForReadOnly : MosWF_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public MosWF_TypedDataContext11_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext11_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext11_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr152GetTree() {
                
                #line 909 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                                curState == 9;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr152Get() {
                
                #line 909 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                                curState == 9;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr152Get() {
                this.GetValueTypeValues();
                return this.@__Expr152Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr153GetTree() {
                
                #line 917 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                                      curRole == targetRole;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr153Get() {
                
                #line 917 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                                      curRole == targetRole;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr153Get() {
                this.GetValueTypeValues();
                return this.@__Expr153Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr161GetTree() {
                
                #line 1050 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                              isNext && curMode == 3;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr161Get() {
                
                #line 1050 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                              isNext && curMode == 3;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr161Get() {
                this.GetValueTypeValues();
                return this.@__Expr161Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr166GetTree() {
                
                #line 1055 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                              isEnd;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr166Get() {
                
                #line 1055 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                              isEnd;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr166Get() {
                this.GetValueTypeValues();
                return this.@__Expr166Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 18))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 18);
                }
                expectedLocationsCount = 18;
                return MosWF_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class MosWF_TypedDataContext12 : MosWF_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public MosWF_TypedDataContext12(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext12(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext12(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr169GetTree() {
                
                #line 2104 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                      targetRole;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr169Get() {
                
                #line 2104 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                      targetRole;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr169Get() {
                this.GetValueTypeValues();
                return this.@__Expr169Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr169Set(int value) {
                
                #line 2104 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                      targetRole = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr169Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr169Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr170GetTree() {
                
                #line 2114 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                      targetNextRole;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr170Get() {
                
                #line 2114 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                      targetNextRole;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr170Get() {
                this.GetValueTypeValues();
                return this.@__Expr170Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr170Set(int value) {
                
                #line 2114 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                      targetNextRole = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr170Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr170Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr171GetTree() {
                
                #line 2124 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                      targetState;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr171Get() {
                
                #line 2124 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                      targetState;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr171Get() {
                this.GetValueTypeValues();
                return this.@__Expr171Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr171Set(int value) {
                
                #line 2124 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                      targetState = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr171Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr171Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr172GetTree() {
                
                #line 2134 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                      targetFunction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr172Get() {
                
                #line 2134 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                      targetFunction;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr172Get() {
                this.GetValueTypeValues();
                return this.@__Expr172Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr172Set(int value) {
                
                #line 2134 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                      targetFunction = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr172Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr172Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr174GetTree() {
                
                #line 2153 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                      targetRole;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr174Get() {
                
                #line 2153 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                      targetRole;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr174Get() {
                this.GetValueTypeValues();
                return this.@__Expr174Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr174Set(int value) {
                
                #line 2153 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                      targetRole = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr174Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr174Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr175GetTree() {
                
                #line 2163 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                      targetNextRole;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr175Get() {
                
                #line 2163 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                      targetNextRole;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr175Get() {
                this.GetValueTypeValues();
                return this.@__Expr175Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr175Set(int value) {
                
                #line 2163 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                      targetNextRole = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr175Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr175Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr176GetTree() {
                
                #line 2173 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                      targetState;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr176Get() {
                
                #line 2173 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                      targetState;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr176Get() {
                this.GetValueTypeValues();
                return this.@__Expr176Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr176Set(int value) {
                
                #line 2173 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                      targetState = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr176Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr176Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr177GetTree() {
                
                #line 2183 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                      targetFunction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr177Get() {
                
                #line 2183 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                      targetFunction;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr177Get() {
                this.GetValueTypeValues();
                return this.@__Expr177Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr177Set(int value) {
                
                #line 2183 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                      targetFunction = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr177Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr177Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 18))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 18);
                }
                expectedLocationsCount = 18;
                return MosWF_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class MosWF_TypedDataContext12_ForReadOnly : MosWF_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public MosWF_TypedDataContext12_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext12_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext12_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr167GetTree() {
                
                #line 58 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
              curMode == 1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr167Get() {
                
                #line 58 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
              curMode == 1;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr167Get() {
                this.GetValueTypeValues();
                return this.@__Expr167Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr168GetTree() {
                
                #line 2144 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
              curMode == 3 && curState != 11;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr168Get() {
                
                #line 2144 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
              curMode == 3 && curState != 11;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr168Get() {
                this.GetValueTypeValues();
                return this.@__Expr168Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr173GetTree() {
                
                #line 2193 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
              curMode == 2;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr173Get() {
                
                #line 2193 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
              curMode == 2;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr173Get() {
                this.GetValueTypeValues();
                return this.@__Expr173Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr178GetTree() {
                
                #line 2198 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
              curMode == 4 || (curMode == 3 && curState == 11);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr178Get() {
                
                #line 2198 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
              curMode == 4 || (curMode == 3 && curState == 11);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr178Get() {
                this.GetValueTypeValues();
                return this.@__Expr178Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr179GetTree() {
                
                #line 2238 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
              curMode < 1 || curMode > 4;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr179Get() {
                
                #line 2238 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
              curMode < 1 || curMode > 4;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr179Get() {
                this.GetValueTypeValues();
                return this.@__Expr179Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 18))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 18);
                }
                expectedLocationsCount = 18;
                return MosWF_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class MosWF_TypedDataContext13 : MosWF_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public MosWF_TypedDataContext13(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext13(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext13(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr181GetTree() {
                
                #line 278 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                  nextRole;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr181Get() {
                
                #line 278 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                  nextRole;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr181Get() {
                this.GetValueTypeValues();
                return this.@__Expr181Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr181Set(int value) {
                
                #line 278 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                  nextRole = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr181Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr181Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr183GetTree() {
                
                #line 290 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                  nextState;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr183Get() {
                
                #line 290 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                  nextState;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr183Get() {
                this.GetValueTypeValues();
                return this.@__Expr183Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr183Set(int value) {
                
                #line 290 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                  nextState = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr183Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr183Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr185GetTree() {
                
                #line 302 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                  nextFunction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr185Get() {
                
                #line 302 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                  nextFunction;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr185Get() {
                this.GetValueTypeValues();
                return this.@__Expr185Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr185Set(int value) {
                
                #line 302 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                  nextFunction = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr185Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr185Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr187GetTree() {
                
                #line 314 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                  isEditMode;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr187Get() {
                
                #line 314 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                  isEditMode;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr187Get() {
                this.GetValueTypeValues();
                return this.@__Expr187Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr187Set(bool value) {
                
                #line 314 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                  isEditMode = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr187Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr187Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr189GetTree() {
                
                #line 326 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                  isNeedAction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr189Get() {
                
                #line 326 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                  isNeedAction;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr189Get() {
                this.GetValueTypeValues();
                return this.@__Expr189Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr189Set(bool value) {
                
                #line 326 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                  isNeedAction = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr189Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr189Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr191GetTree() {
                
                #line 338 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                  nextCount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr191Get() {
                
                #line 338 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                  nextCount;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr191Get() {
                this.GetValueTypeValues();
                return this.@__Expr191Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr191Set(int value) {
                
                #line 338 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                  nextCount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr191Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr191Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 18))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 18);
                }
                expectedLocationsCount = 18;
                return MosWF_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class MosWF_TypedDataContext13_ForReadOnly : MosWF_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public MosWF_TypedDataContext13_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext13_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext13_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr180GetTree() {
                
                #line 283 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                  targetNextRole;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr180Get() {
                
                #line 283 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                  targetNextRole;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr180Get() {
                this.GetValueTypeValues();
                return this.@__Expr180Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr182GetTree() {
                
                #line 295 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                  targetState;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr182Get() {
                
                #line 295 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                  targetState;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr182Get() {
                this.GetValueTypeValues();
                return this.@__Expr182Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr184GetTree() {
                
                #line 307 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                  targetFunction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr184Get() {
                
                #line 307 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                  targetFunction;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr184Get() {
                this.GetValueTypeValues();
                return this.@__Expr184Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr186GetTree() {
                
                #line 319 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                  targetEditMode;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr186Get() {
                
                #line 319 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                  targetEditMode;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr186Get() {
                this.GetValueTypeValues();
                return this.@__Expr186Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr188GetTree() {
                
                #line 331 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                  targetNeedAction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr188Get() {
                
                #line 331 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                  targetNeedAction;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr188Get() {
                this.GetValueTypeValues();
                return this.@__Expr188Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr190GetTree() {
                
                #line 343 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                  extCount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr190Get() {
                
                #line 343 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                  extCount;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr190Get() {
                this.GetValueTypeValues();
                return this.@__Expr190Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 18))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 18);
                }
                expectedLocationsCount = 18;
                return MosWF_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class MosWF_TypedDataContext14 : MosWF_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public MosWF_TypedDataContext14(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext14(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext14(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr195GetTree() {
                
                #line 1139 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                                                targetEditMode;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr195Get() {
                
                #line 1139 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                                                targetEditMode;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr195Get() {
                this.GetValueTypeValues();
                return this.@__Expr195Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr195Set(bool value) {
                
                #line 1139 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                                                targetEditMode = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr195Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr195Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr196GetTree() {
                
                #line 1149 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                                                targetNeedAction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr196Get() {
                
                #line 1149 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                                                targetNeedAction;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr196Get() {
                this.GetValueTypeValues();
                return this.@__Expr196Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr196Set(bool value) {
                
                #line 1149 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                                                targetNeedAction = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr196Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr196Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr197GetTree() {
                
                #line 1162 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                                              targetEditMode;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr197Get() {
                
                #line 1162 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                                              targetEditMode;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr197Get() {
                this.GetValueTypeValues();
                return this.@__Expr197Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr197Set(bool value) {
                
                #line 1162 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                                              targetEditMode = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr197Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr197Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr198GetTree() {
                
                #line 1176 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                                          targetEditMode;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr198Get() {
                
                #line 1176 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                                          targetEditMode;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr198Get() {
                this.GetValueTypeValues();
                return this.@__Expr198Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr198Set(bool value) {
                
                #line 1176 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                                          targetEditMode = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr198Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr198Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr200GetTree() {
                
                #line 1188 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                                      extCount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr200Get() {
                
                #line 1188 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                                      extCount;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr200Get() {
                this.GetValueTypeValues();
                return this.@__Expr200Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr200Set(int value) {
                
                #line 1188 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                                      extCount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr200Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr200Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr201GetTree() {
                
                #line 1200 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                                      isEnd;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr201Get() {
                
                #line 1200 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                                      isEnd;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr201Get() {
                this.GetValueTypeValues();
                return this.@__Expr201Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr201Set(bool value) {
                
                #line 1200 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                                      isEnd = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr201Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr201Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr202GetTree() {
                
                #line 1210 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                                      isNext;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr202Get() {
                
                #line 1210 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                                      isNext;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr202Get() {
                this.GetValueTypeValues();
                return this.@__Expr202Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr202Set(bool value) {
                
                #line 1210 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                                      isNext = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr202Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr202Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr203GetTree() {
                
                #line 1224 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                                      targetEditMode;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr203Get() {
                
                #line 1224 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                                      targetEditMode;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr203Get() {
                this.GetValueTypeValues();
                return this.@__Expr203Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr203Set(bool value) {
                
                #line 1224 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                                      targetEditMode = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr203Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr203Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr204GetTree() {
                
                #line 1234 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                                      isEnd;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr204Get() {
                
                #line 1234 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                                      isEnd;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr204Get() {
                this.GetValueTypeValues();
                return this.@__Expr204Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr204Set(bool value) {
                
                #line 1234 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                                      isEnd = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr204Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr204Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr205GetTree() {
                
                #line 1244 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                                      isNext;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr205Get() {
                
                #line 1244 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                                      isNext;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr205Get() {
                this.GetValueTypeValues();
                return this.@__Expr205Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr205Set(bool value) {
                
                #line 1244 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                                      isNext = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr205Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr205Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr207GetTree() {
                
                #line 1420 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                                      targetRole;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr207Get() {
                
                #line 1420 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                                      targetRole;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr207Get() {
                this.GetValueTypeValues();
                return this.@__Expr207Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr207Set(int value) {
                
                #line 1420 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                                      targetRole = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr207Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr207Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr208GetTree() {
                
                #line 1430 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                                      targetNextRole;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr208Get() {
                
                #line 1430 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                                      targetNextRole;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr208Get() {
                this.GetValueTypeValues();
                return this.@__Expr208Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr208Set(int value) {
                
                #line 1430 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                                      targetNextRole = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr208Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr208Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr209GetTree() {
                
                #line 1440 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                                      targetState;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr209Get() {
                
                #line 1440 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                                      targetState;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr209Get() {
                this.GetValueTypeValues();
                return this.@__Expr209Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr209Set(int value) {
                
                #line 1440 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                                      targetState = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr209Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr209Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr210GetTree() {
                
                #line 1450 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                                      targetFunction;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr210Get() {
                
                #line 1450 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                                      targetFunction;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr210Get() {
                this.GetValueTypeValues();
                return this.@__Expr210Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr210Set(int value) {
                
                #line 1450 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                                                                                      targetFunction = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr210Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr210Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 18))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 18);
                }
                expectedLocationsCount = 18;
                return MosWF_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class MosWF_TypedDataContext14_ForReadOnly : MosWF_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public MosWF_TypedDataContext14_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext14_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext14_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr192GetTree() {
                
                #line 1116 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                                curState == 8;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr192Get() {
                
                #line 1116 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                                curState == 8;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr192Get() {
                this.GetValueTypeValues();
                return this.@__Expr192Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr193GetTree() {
                
                #line 1124 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                                      curRole == targetRole;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr193Get() {
                
                #line 1124 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                                      curRole == targetRole;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr193Get() {
                this.GetValueTypeValues();
                return this.@__Expr193Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr194GetTree() {
                
                #line 1131 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                                          curMode == 2;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr194Get() {
                
                #line 1131 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                                          curMode == 2;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr194Get() {
                this.GetValueTypeValues();
                return this.@__Expr194Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr199GetTree() {
                
                #line 1193 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                                      extCount + 1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr199Get() {
                
                #line 1193 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                                      extCount + 1;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr199Get() {
                this.GetValueTypeValues();
                return this.@__Expr199Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr206GetTree() {
                
                #line 1460 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                              isNext && curMode == 2;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr206Get() {
                
                #line 1460 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                              isNext && curMode == 2;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr206Get() {
                this.GetValueTypeValues();
                return this.@__Expr206Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr211GetTree() {
                
                #line 1465 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                              isEnd;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr211Get() {
                
                #line 1465 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                                                                              isEnd;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr211Get() {
                this.GetValueTypeValues();
                return this.@__Expr211Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 18))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 18);
                }
                expectedLocationsCount = 18;
                return MosWF_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class MosWF_TypedDataContext15 : MosWF_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public MosWF_TypedDataContext15(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext15(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext15(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr212GetTree() {
                
                #line 2207 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                          targetEditMode;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr212Get() {
                
                #line 2207 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                          targetEditMode;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr212Get() {
                this.GetValueTypeValues();
                return this.@__Expr212Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr212Set(bool value) {
                
                #line 2207 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                          targetEditMode = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr212Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr212Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr213GetTree() {
                
                #line 2217 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                          isEnd;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr213Get() {
                
                #line 2217 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                          isEnd;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr213Get() {
                this.GetValueTypeValues();
                return this.@__Expr213Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr213Set(bool value) {
                
                #line 2217 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                
                          isEnd = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr213Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr213Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 18))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 18);
                }
                expectedLocationsCount = 18;
                return MosWF_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class MosWF_TypedDataContext15_ForReadOnly : MosWF_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public MosWF_TypedDataContext15_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext15_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public MosWF_TypedDataContext15_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr214GetTree() {
                
                #line 2229 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      isEnd;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr214Get() {
                
                #line 2229 "C:\USERS\M.CHANDRASEGARAM\DOCUMENTS\TESTING\SOURCE\SOURCE\REPOS\ESSIC\EMOSWF\MOSWF.XAML"
                return 
                      isEnd;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr214Get() {
                this.GetValueTypeValues();
                return this.@__Expr214Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 18))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 18);
                }
                expectedLocationsCount = 18;
                return MosWF_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
