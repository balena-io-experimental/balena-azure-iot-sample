
add_executable(doublylinkedlist_unittests doublylinkedlist_unittests.cpp main.c)


target_include_directories(doublylinkedlist_unittests PUBLIC ${TEST_INCLUDES})
target_link_libraries (doublylinkedlist_unittests ${CMAKE_THREAD_LIBS_INIT} ctest micromock common)
