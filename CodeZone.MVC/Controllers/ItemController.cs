using AutoMapper;
using CodeZone.Application.Features.Items.Command.Create;
using CodeZone.Application.Features.Items.Command.Delete;
using CodeZone.Application.Features.Items.Command.Update;
using CodeZone.Application.Features.Items.Query.GetAllItems;
using CodeZone.Application.Features.Items.Query.GetItem;
using CodeZone.Application.Features.Stores.Command.Create;
using CodeZone.Application.Features.Stores.Command.Delete;
using CodeZone.Application.Features.Stores.Command.Update;
using CodeZone.Application.Features.Stores.Query.GetAllStores;
using CodeZone.Application.Features.Stores.Query.GetStore;
using CodeZone.MVC.ViewModels.Item;
using CodeZone.MVC.ViewModels.Store;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CodeZone.MVC.Controllers
{
    public class ItemController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        public ItemController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var dtos = await _mediator.Send(new GetAllItemsQuery());
            var viewModels = _mapper.Map<IReadOnlyList<ItemListViewModel>>(dtos);
            return View(viewModels);
        }

        public async Task<IActionResult> Details(int id)
        {
            var dto = await _mediator.Send(new GetItemQuery { Id = id });
            var viewModel = _mapper.Map<ItemDetailesViewModel>(dto);
            return View(viewModel);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(ItemViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var command = _mapper.Map<CreateItemCommand>(viewModel);
                await _mediator.Send(command);
                return RedirectToAction("Index");
            }
            return View(viewModel);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var dto = await _mediator.Send(new GetItemQuery { Id = id });
            var viewModel = _mapper.Map<ItemViewModel>(dto);
            return View(viewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(ItemViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var command = _mapper.Map<UpdateItemCommand>(viewModel);
                await _mediator.Send(command);
                return RedirectToAction("Index");
            }
            return View(viewModel);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var dto = await _mediator.Send(new GetItemQuery { Id = id });
            var viewModel = _mapper.Map<ItemListViewModel>(dto);
            return View(viewModel);
        }
        public async Task<IActionResult> ConfirmDelete(int id)
        {
            await _mediator.Send(new DeleteItemCommand { Id = id });
            return RedirectToAction("Index");
        }
    }
}
