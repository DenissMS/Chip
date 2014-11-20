var body = $('.body');
var content = $('#content');
var controller = 'Home';
var caption = $('.page-title');
var selectedDay = null,
    selectedGroup = null;
var currentPage;

var curPage = {
    content: '',
    action: '',
    title: ''
};
var pages = {
    schedules: { content: '', action: 'Schedules', section: 'Schedules', title: 'Schedules' },
    groupSelect: { content: '', action: 'GroupSelection', section: 'GroupSelection', title: 'Select group' },
    manageSchedule: { content: '', action: 'ManageSchedule', section: 'ManageSchedule', title: 'Schedule edit' },
    teachers: { content: '', action: 'Management', section: 'Teachers', title: 'Teachers' },
    lessons: { content: '', action: 'Management', section: 'Lessons', title: 'Lessons' },
    subjects: { content: '', action: 'Management', section: 'Subjects', title: 'Subjects' },
    groups: { content: '', action: 'Management', section: 'Groups', title: 'Groups' }
};

$(document).ready(function () {
    body = $('.body');
    $('.bigtext').bigtext();
    $('#left-bar').bigtext();
    $.fn.extend({
        animateSequentially: function () {
            this.each(function (i) {
                $(this).delay((i++) * 20).fadeTo(500, 1);
            });
        },
    });
});
Resize();

function Load(page) {
    currentPage = page;
    $('.bigtext').bigtext();
    switch (page) {
        case 'Schedules':
            if(selectedGroup != null)
                curPage = pages.schedules;
            else 
                curPage = pages.groupSelect;
            caption.text(curPage.title);
            caption.show();
            LoadContent(selectedGroup);
            return;
        case 'ManageSchedule':
            curPage = pages.manageSchedule;
            if (selectedGroup != null && selectedDay != null) {
                LoadContent([selectedGroup, selectedDay]);
            }
            return;
        case 'Groups':
            curPage = pages.groups; break;
        case 'Teachers':
            curPage = pages.teachers; break;
        case 'Subjects':
            curPage = pages.subjects; break;
        case 'Lessons':
            curPage = pages.lessons; break;
    }
    caption.text(curPage.title);
    caption.show();
    LoadContent();
}

function LoadContent(param) {
    $.post(controller + '/' + curPage.action,
        $.param({ section: curPage.section, param: param }, true),
        function (result) {
            content.html(result);
        })
        .fail(function (xhr) {
            DisplayErrorMessage(xhr.responseText);
        });
}

function SelectGroup() {
    var list = $('#list')[0];
    selectedGroup = list.options[list.selectedIndex].id;
    Load('Schedules');
}

function SelectDay(day) {
    selectedDay = day.id;
}

function DisplayErrorMessage(html) {
}

function LoadDetails() {
    var el = $('#list')[0];
    var id = el.options[el.selectedIndex].id;
    $.post(controller + '/' + 'GetDetailsJson',
        { section: curPage.section, id: id },
        function (result) {
            $.each(Object.keys(result), function (index, value) {
                $('#' + value).val(result[value]);
            });
        })
        .fail(function (xhr) {
            DisplayErrorMessage(xhr.responseText);
        });
}

window.onresize = function () {
    window.setTimeout(Resize, 100);
}

function Add() {
    Send('Add', { section: curPage.section, data: getData() });
}

function Edit() {
    Send('Edit', {
        section: curPage.section,
        id: getId(),
        data: getData()
    });
}

function Remove() {
    Send('Remove', { section: curPage.section, id: getId() });
}

function AddLesson(id) {
    var data = [
        id,
        getOptionId('#lessons'),
        getOptionId('#subjects'),
        getOptionId('#teachers'),
        getOptionId('#rooms')
    ];
    Send('Add', {section: curPage.section, data: data});
}
function getOptionId(selector) {
    var s = $(selector)[0];
    return s.options[s.selectedIndex].id;
}
function RemoveLesson(id) {
    Send('Remove', {
        section: curPage.section,
        id: getOptionId('#concreteLessons')
    });
}

function Send(action, data) {
    $.post(controller + '/' + action, 
        $.param(data, true), function (result) {
            Load(currentPage);
        })
   .fail(function (xhr) {
       DisplayErrorMessage(xhr.responseText);
   });
}

function getId() {
    var list = $('#list')[0];
    return list.options[list.selectedIndex].id;
}

function getData() {
    var data = [];
    $('.details').children()
        .each(function () {
            if ($(this).find('input').length) {
                data.push($(this).children('input').val());
            }
        });
    return data;
}

function Resize() {
    var width;
    if (body.width() > body.height()) {
        width = body.height();
    } else {
        width = body.width();
    }
    var container = $('#container');
    $('#container').width(width);
    container.height(width * 0.6);
    container.margin({
        left: body.width() * 0.5
            - container.width() * 0.5 - container.padding().left
    });
}