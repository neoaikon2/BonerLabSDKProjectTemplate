using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Forklift;
using SLZ.Marrow.Forklift.Model;
using SLZ.Marrow.Warehouse;
using SLZ.SaveData;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;

namespace SLZ.UI
{
	public class UI_ModGroup : MonoBehaviour
	{
		[Serializable]
		public enum PageType
		{
			Installed = 0,
			Approved = 1,
			External = 2,
			Repos = 3,
			Mods = 4
		}

		[Serializable]
		public struct UI_ModPager
		{
			public GameObject forwardButton;

			public GameObject backButton;

			public TextMeshProUGUI txt_pageNumber;

			public PageType currentPageType;

			public int currentPage;
		}

		[Serializable]
		public struct UI_ModSettings
		{
			public TextMeshProUGUI txt_maxConcurrent;

			public TextMeshProUGUI txt_perHost;

			public TextMeshProUGUI txt_developerMode;

			public TextMeshProUGUI txt_developerModePort;
		}

		[Serializable]
		public class UI_ModViewModel
		{
			public string text;

			public Pallet pallet;

			public ModListing modListing;

			public ModTarget modTarget;

			public bool useItemImage;

			public string itemImageUrl;

			public bool useVersion;

			public bool useProgressBar;

			public float progress;

			public bool isInstalled;
		}

		[Serializable]
		public class UI_ModCell
		{
			public delegate void OnCellClickedDelegate(ref UI_ModCell cell);

			public GameObject gameObject;

			public TextMeshProUGUI itemText;

			public TextMeshProUGUI modVersionText;

			public GameObject itemImage;

			public ProgressBar progressBar;

			[HideInInspector]
			public string itemImageUrl;

			public UniTask<Sprite> itemImageTask;

			public CancellationTokenSource itemImageCTS;

			[HideInInspector]
			public bool selected;

			[HideInInspector]
			public int viewModelIndex;

			public OnCellClickedDelegate OnCellClicked;

			public void UpdateFromViewModel(UI_ModViewModel viewModel, UI_ModGroup context)
			{
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CLoad_Repositories_003Ed__32
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public UI_ModGroup _003C_003E4__this;

			private UnityWebRequest _003CinternalUwr_003E5__2;

			private UniTask<UnityWebRequest>.Awaiter _003C_003Eu__1;

			private UniTask<List<ModRepository>>.Awaiter _003C_003Eu__2;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		public TextMeshProUGUI txt_pageTitle;

		public TextMeshProUGUI txt_sdkVersion;

		public string[] string_pageTitle;

		public Sprite defaultImage;

		public UI_ModSettings uiModSettings;

		public UI_ModPager pager;

		public UI_ModCell[] cells;

		private ModRepository officialRepository;

		private List<ModRepository> otherRepositories;

		private List<UI_ModViewModel> viewModels;

		private Dictionary<string, Sprite> spriteCache;

		public GameObject obj_DevModeWarning;

		public GameObject obj_AvatarWarning;

		public GameObject obj_ModWarning;

		private const string REPO_APPROVED = "https://mods.stresslevelzero.com/repository.json";

		private ModDownloadManager modDownloadManager { get; set; }

		private int PageCount => 0;

		private static PlayerProgression Progression => null;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void PortChanged(object sender, PropertyChangedEventArgs e)
		{
		}

		private void OnDestroy()
		{
		}

		private void ModDownloadManager_OnModDownload(ModDownloadManager modDownloadManager, FileDownloader.TaskItem taskItem, ModDownloadManager.ModDownloadState state, float progress)
		{
		}

		[AsyncStateMachine(typeof(_003CLoad_Repositories_003Ed__32))]
		private UniTask Load_Repositories()
		{
			return default(UniTask);
		}

		public void BUTTON_MODSETTINGS(int buttonNumber = 0)
		{
		}

		private void DevModeWarning()
		{
		}

		public void BUTTON_SELECT(int idx)
		{
		}

		private void OnCellClicked(ref UI_ModCell cell)
		{
		}

		public void BUTTON_OPENPAGE(int pageTypeInt = 0)
		{
		}

		public void BUTTON_BACK()
		{
		}

		public void BUTTON_FORWARD()
		{
		}

		public void BUTTON_DELETE(bool deleteAll = true)
		{
		}

		private void PopulateMenu(PageType pageType)
		{
		}

		private void UpdatePagerUI(int newPageIndex)
		{
		}

		private void UpdateCells(int newPageIndex)
		{
		}

		public void WARNINGS()
		{
		}
	}
}
