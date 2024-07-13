using AutoMapper;
using CodeZone.Application.Features.Items.Query.GetAllItems;
using CodeZone.Application.Features.Stores.Query.GetAllStores;
using CodeZone.Application.Features.StoresItems.Command.PurchaseStoreItem;
using CodeZone.Application.Features.StoresItems.Command.SellStoreItem;
using CodeZone.Application.Features.StoresItems.Query.GetBalance;
using CodeZone.MVC.ViewModels.Item;
using CodeZone.MVC.ViewModels.Process;
using CodeZone.MVC.ViewModels.Store;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CodeZone.MVC.Controllers
{
    public class ProcessController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public ProcessController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Purchase(int storeId, int itemId)
        {
            var itemsDtos = await _mediator.Send(new GetAllItemsQuery());
            var storesDtos = await _mediator.Send(new GetAllStoresQuery());

            var itemsViewModels = _mapper.Map<IReadOnlyList<ItemListViewModel>>(itemsDtos);
            var storesViewModels = _mapper.Map<IReadOnlyList<StoreViewModel>>(storesDtos);

            var viewModel = new ProcessViewModel
            {
                Items = itemsViewModels,
                Stores = storesViewModels,
                ItemId = itemId,
                StoreId = storeId
            };
            return View(viewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Purchase(ProcessViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var command = _mapper.Map<PurchaseStoreItemCommand>(viewModel);
                await _mediator.Send(command);
            }
            return RedirectToAction("Purchase", new { viewModel.StoreId, viewModel.ItemId });
        }
        public async Task<IActionResult> Sell(int storeId, int itemId)
        {
            var itemsDtos = await _mediator.Send(new GetAllItemsQuery());
            var storesDtos = await _mediator.Send(new GetAllStoresQuery());

            var itemsViewModels = _mapper.Map<IReadOnlyList<ItemListViewModel>>(itemsDtos);
            var storesViewModels = _mapper.Map<IReadOnlyList<StoreViewModel>>(storesDtos);

            var viewModel = new ProcessViewModel
            {
                Items = itemsViewModels,
                Stores = storesViewModels,
                ItemId = itemId,
                StoreId = storeId
            };
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Sell(ProcessViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var command = _mapper.Map<SellStoreItemCommand>(viewModel);
                await _mediator.Send(command);
            }
            return RedirectToAction("Sell", new { viewModel.StoreId, viewModel.ItemId });
        }

        public async Task<IActionResult> GetBalance(int storeId, int itemId)
        {
            var balance = await _mediator.Send(new GetBalanceQuery { StoreId = storeId, ItemId = itemId });
            return Ok(balance);
        }
    }
}
