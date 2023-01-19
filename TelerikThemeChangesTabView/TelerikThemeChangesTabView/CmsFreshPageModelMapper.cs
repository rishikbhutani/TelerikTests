using FreshMvvm;
using System;
using TelerikThemeChangesTabView.Views;

namespace Sample.Mapper
{
    public class SampleFreshPageModelMapper : IFreshPageModelMapper
    {
        readonly string pageNamespace = typeof(AboutPage).Namespace;
        readonly string pageAssemblyName;

        public SampleFreshPageModelMapper(string pageNamespace = null, string pageAssemblyName = null)
        {
            if (pageNamespace != null)
                this.pageNamespace = pageNamespace;
            this.pageAssemblyName = pageAssemblyName;
        }

        public string GetPageTypeName(Type pageModelType)
        {
            var assemblyQualifiedName = pageModelType.AssemblyQualifiedName;

            // Replace Namespace
            if (pageNamespace != null)
                assemblyQualifiedName = assemblyQualifiedName.Replace(pageModelType.Namespace, pageNamespace);

            // Replace Assembly
            if (pageAssemblyName != null)
                assemblyQualifiedName = assemblyQualifiedName.Replace(pageModelType.Assembly.ToString(), pageAssemblyName);

            // Replace "Model"
            assemblyQualifiedName = assemblyQualifiedName
                .Replace("ViewModel", "Page");

            return assemblyQualifiedName;
        }
    }
}