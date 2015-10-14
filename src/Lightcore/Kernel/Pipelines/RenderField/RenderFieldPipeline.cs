using System;
using System.Collections.Generic;
using Lightcore.Kernel.Data;
using Lightcore.Kernel.Pipelines.RenderField.Processors;
using Lightcore.Kernel.Urls;

namespace Lightcore.Kernel.Pipelines.RenderField
{
    public class RenderFieldPipeline : Pipeline
    {
        private readonly IItemProvider _itemProvider;
        private readonly IItemUrlService _itemUrlService;

        public RenderFieldPipeline(IItemProvider itemProvider, IItemUrlService itemUrlService)
        {
            _itemProvider = itemProvider;
            _itemUrlService = itemUrlService;
        }

        public override IEnumerable<Processor> GetProcessors()
        {
            yield return new RenderLinkFieldProcessor();
            yield return new RenderMediaFieldProcessor();
            yield return new RenderFieldProcessor();
        }

        public override void Run(PipelineArgs args)
        {
            var renderFieldArgs = (RenderFieldArgs)args;

            if (renderFieldArgs.Field == null)
            {
                args.AbortPipeline();

                return;
            }

            base.Run(args);
        }

        public RenderFieldArgs GetArgs(Item item, Field field)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            return new RenderFieldArgs(_itemProvider, _itemUrlService, item, field);
        }
    }
}