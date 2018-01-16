using System;
using Foundation;
using CoreGraphics;
using UIKit;
using ObjCRuntime;
using MaterialComponents.MaterialInk;
using MaterialComponents.MaterialButtons;
using MaterialComponents;

namespace MaterialComponents.MaterialBottomNavigation
{
    // @interface MDCBottomNavigationBar : UIView
    [BaseType(typeof(UIView))]
    interface MDCBottomNavigationBar
    {
        [Wrap("WeakDelegate")]
        [NullAllowed]
        MDCBottomNavigationBarDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<MDCBottomNavigationBarDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (assign, nonatomic) MDCBottomNavigationBarTitleVisibility titleVisibility __attribute__((annotate("ui_appearance_selector")));
        [Export("titleVisibility", ArgumentSemantic.Assign)]
        MDCBottomNavigationBarTitleVisibility TitleVisibility { get; set; }

        // @property (assign, nonatomic) MDCBottomNavigationBarAlignment alignment __attribute__((annotate("ui_appearance_selector")));
        [Export("alignment", ArgumentSemantic.Assign)]
        MDCBottomNavigationBarAlignment Alignment { get; set; }

        // @property (copy, nonatomic) NSArray<UITabBarItem *> * _Nonnull items;
        [Export("items", ArgumentSemantic.Copy)]
        UITabBarItem[] Items { get; set; }

        // @property (nonatomic, weak) UITabBarItem * _Nullable selectedItem;
        [NullAllowed, Export("selectedItem", ArgumentSemantic.Weak)]
        UITabBarItem SelectedItem { get; set; }

        // @property (nonatomic, strong) UIFont * _Nonnull itemTitleFont __attribute__((annotate("ui_appearance_selector")));
        [Export("itemTitleFont", ArgumentSemantic.Strong)]
        UIFont ItemTitleFont { get; set; }

        // @property (readwrite, nonatomic, strong) UIColor * _Nonnull selectedItemTintColor __attribute__((annotate("ui_appearance_selector")));
        [Export("selectedItemTintColor", ArgumentSemantic.Strong)]
        UIColor SelectedItemTintColor { get; set; }

        // @property (readwrite, nonatomic, strong) UIColor * _Nonnull unselectedItemTintColor __attribute__((annotate("ui_appearance_selector")));
        [Export("unselectedItemTintColor", ArgumentSemantic.Strong)]
        UIColor UnselectedItemTintColor { get; set; }
    }

    // @protocol MDCBottomNavigationBarDelegate <UINavigationBarDelegate>
    [BaseType(typeof(UINavigationBarDelegate))]
    [Protocol, Model]
    interface MDCBottomNavigationBarDelegate
    {
        // @optional -(BOOL)bottomNavigationBar:(MDCBottomNavigationBar * _Nonnull)bottomNavigationBar shouldSelectItem:(UITabBarItem * _Nonnull)item;
        [Export("bottomNavigationBar:shouldSelectItem:")]
        bool BottomNavigationBar_ShouldSelectItem(MDCBottomNavigationBar bottomNavigationBar, UITabBarItem item);

        // @optional -(void)bottomNavigationBar:(MDCBottomNavigationBar * _Nonnull)bottomNavigationBar didSelectItem:(UITabBarItem * _Nonnull)item;
        [Export("bottomNavigationBar:didSelectItem:")]
        void BottomNavigationBar_DidSelectItem(MDCBottomNavigationBar bottomNavigationBar, UITabBarItem item);
    }
}
